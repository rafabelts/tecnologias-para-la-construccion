from abc import ABC, abstractmethod


class Ave(ABC):
    @abstractmethod
    def volar(self):
        pass

    @abstractmethod
    def comer(self):
        pass

    @abstractmethod
    def nadar(self):
        pass


class Aguila(Ave):
    def volar(self):
        print("Aguila está volando...")

    def comer(self):
        print("Aguila está nadando")

    def nadar(self):
        raise Exception("Aguila no puede nadar")


class Paloma(Ave):
    def volar(self):
        print("Paloma está volando...")

    def comer(self):
        print("Paloma está nadando")

    def nadar(self):
        raise Exception("Paloma no puede nadar")


class Pinguino(Ave):
    def volar(self):
        raise Exception("Pingüino no puede volar")

    def comer(self):
        print("Pingüino está comiendo")

    def nadar(self):
        print("Pingüino está nadando")


a1 = Aguila()
pa1 = Paloma()
p1 = Pinguino()


try:
    a1.comer()
    a1.volar()
    a1.nadar()
except Exception as e:
    print(f"An exception occurred {e}")

try:
    pa1.comer()
    pa1.volar()
    pa1.nadar()
except Exception as e:
    print(f"An exception occurred {e}")

try:
    p1.nadar()
    p1.comer()
    p1.volar()
except Exception as e:
    print(f"An exception occurred {e}")
