class A:
    def metodo(self):
        print("from A")
        
class B(A):
    def metodo(self):
        print("from B")
        
class C(A):
    def metodo(self):
        print("from C")
        
class D(B, C):
    def hello(self):
        print("from D")

d = D()

print(D.mro())
d.metodo()        