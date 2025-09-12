class Animal:
    def hablar(self):
        raise NotImplementedError("No implementado")


class Perro(Animal):
    def hablar(self):
        return "guau"


class Gato(Animal):
    def hablar(self):
        return "miau"


class Caja:
    def __init__(self):
        self._items = []

    def meter(self, x):
        self._items.append(x)

    def primero(self):
        return self._items[0]


def describir(a):
    if isinstance(a, Perro):
        return "Es un perrito"
    elif isinstance(a, Gato):
        return "Es un gato"
    else:
        return ""


def saludar(animal: Animal):
    print(animal.hablar())


saludar(Perro())
saludar(Gato())

c1 = Caja()
c2 = Caja()

c1.meter(Perro())
c2.meter(Gato())

print(c1.primero().hablar())
print(c2.primero().hablar())
