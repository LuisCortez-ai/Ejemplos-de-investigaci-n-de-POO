#Ejemplo 2
class Telefono:
    def __init__(self, Modelo="", Año=0, Sonar=0):
        self.Modelo = Modelo
        self.Año =  Año
        self.Sonar = Sonar
    def smartphone_nuevo(self):
        print(f"\n\tEl modelo del smartphone es {self.Modelo} del año {self.Año}")
    def mejoras(self):
        if self.Sonar == 1:
            print("\tEl smartphone está sonando")
        else:
            print("\tEl smartohne no está sonando")
#Creando instancias de objetos
smartphone1= Telefono("Samsung Note 8", 2025, 1)
smartphone2= Telefono("Xiaomi Redmi 12", 2025, 0)
#Llamada de métodos
smartphone1.smartphone_nuevo()
smartphone1.mejoras()
smartphone2.smartphone_nuevo()
smartphone2.mejoras()