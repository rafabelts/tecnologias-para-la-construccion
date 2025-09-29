from datetime import date, datetime


class Logger:
    def __init__(self) -> None:
        self._logs = []

    def log(self, message: str) -> None:
        self._logs.append(f"[{datetime.now().strftime('%Y-%m-%d %H:%M')}] {message}")

    def show_logs(self) -> list[str]:
        return self._logs


class Usuario:
    def __init__(self, usuario_id: int, nombre: str) -> None:
        self.id = usuario_id
        self.nombre = nombre
        self.pedidos: list["Pedido"] = []
        self.logger = Logger()

    def registrar(self) -> None:
        self.logger.log(f"El usuario {self.nombre} se ha registrado")

    def agregar_pedido(self, pedido: "Pedido") -> None:
        self.pedidos.append(pedido)
        self.logger.log(f"El pedido {pedido.id}")

    def get_pedidos(self) -> list["Pedido"]:
        return self.pedidos


class Pedido:
    def __init__(self, pedido_id: int, fecha: date, monto: float) -> None:
        self.id = pedido_id
        self.fecha = fecha
        self.date = date
        self.monto = monto
        self.estado = "Pendiente"
        self.logger = Logger()

    def procesar(self) -> None:
        self.estado = "Procesado"
        self.logger.log(f"El pedido {self.id} se ha procesado")

    def cancelar(self) -> None:
        self.estado = "Cancelado"
        self.logger.log(f"El pedido {self.id} se ha cancelado")

    def mostar_detalles(self) -> str:
        return f"Pedido: {self.id} \t Fecha: {self.fecha} \t Monto: {self.monto}"


if __name__ == "__main__":
    usuario = Usuario(1, "Fernandito")
    usuario.registrar()

    p1 = Pedido(101, date.today(), 1000)
    p1.procesar()

    p2 = Pedido(102, date.today(), 10000)
    p2.cancelar()

    print("Pedidos del usuario")
    for pedido in usuario.get_pedidos():
        print(pedido.mostar_detalles())

    print("Registros del pedido 1")
    for log_pedido_1 in p1.logger.show_logs():
        print(log_pedido_1)

    print("Registros del pedido 2")
    for log_pedido_2 in p2.logger.show_logs():
        print(log_pedido_2)

