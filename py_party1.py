class Partyanimal():
    x=0

    def party(self):
        self.x = self.x +1
        print('So Far',self.x)

    def animal(count):
        count.x = count.x +2
        print('Count :',count.x)
an = Partyanimal()
an.party()
an.party()
an.party()
an.animal()
an.animal()
an.animal()
