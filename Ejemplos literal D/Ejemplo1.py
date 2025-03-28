#Ejemplo 1
class CuentadeBitcoin:
    def __init__(self, saldo=0.0):
         self.saldo = saldo

    def retirar(self, cantidad):
     if self.saldo >= cantidad:
         self.saldo -= cantidad
         print("\tRetiro exitoso. Nuevo saldo:"+ str(round(self.saldo,2)))
     else: 
        print("\tNo hay suficientes fondos para retirar")

Cuenta1=CuentadeBitcoin(0)
Cuenta2=CuentadeBitcoin(170.3)
Cuenta3=CuentadeBitcoin(245.5)

#Imprimiendo valores
Cuenta1.retirar(50.0)
Cuenta2.retirar(50.0)
Cuenta3.retirar(50.0)
