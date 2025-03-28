#Ejemplo 1
#Clase padre
class CuentadeBitcoin:
#Definimos atributos y métodos de la clase padre
    def __init__(self, saldo=0.0):
         self.saldo = saldo

    def retirar(self, cantidad):
     if self.saldo >= cantidad:
         self.saldo -= cantidad
         print("\tRetiro exitoso. Nuevo saldo:"+ str(round(self.saldo,2)))
     else: 
        print("\tNo hay suficientes fondos para retirar")
# Subclase que herada de CuentaDeBitcoin
#Definimos atributos y métodos de la clase heredada
class CuentaPremium(CuentadeBitcoin):
    def __init__(self, saldo=0.0, cashback=0.05):
        #Llamamos a la clase padre
        super().__init__(saldo)
        self.cashback = cashback
    def retirarCP(self, cantidad):
        if self.saldo >= cantidad:
            self.saldo -= cantidad
            cashback_ganado = cantidad * self.cashback
            self.saldo += cashback_ganado
            print(f"\tRetiro exitosos con cashback. Nuevo saldo:"+ str(round(self.saldo,2))+ f" (Cashback: {cashback_ganado})")
        else:
            print("\tNo hay suficientes fondos para retirar")

#Creamos instancias de los objetos
Cuenta_normal=CuentadeBitcoin(0)
Cuenta_gold=CuentaPremium(170.3)

#Imprimiendo valores
Cuenta_normal.retirar(50.0)
Cuenta_gold.retirarCP(50.0)
