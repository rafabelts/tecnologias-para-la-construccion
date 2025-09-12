from abc import ABC, abstractmethod


class Ave(ABC):
    @abstractmethod
    def comer(self):
        pass


class AveNadadora(Ave):
    @abstractmethod
    def nadar(self):
        pass


class AveVoladora(Ave):
    @abstractmethod
    def volar(self):
        pass


class Aguila(AveVoladora):
    def volar(self):
        print("Aguila está volando...")

    def comer(self):
        print("Aguila está nadando")


class Paloma(AveVoladora):
    def volar(self):
        print("Paloma está volando...")

    def comer(self):
        print("Paloma está nadando")


class Pinguino(AveNadadora):
    def comer(self):
        print("Pingüino está comiendo")

    def nadar(self):
        print("Pingüino está nadando")


a1 = Aguila()
pa1 = Paloma()
p1 = Pinguino()

a1.comer()
a1.volar()

print()

pa1.comer()
pa1.volar()

print()

p1.comer()
p1.nadar()
