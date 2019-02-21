class CaesarCipher():
    arr_1 = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
    arr_2 = arr_1[:]
    def change_alph(self, number):
        for i in range(number):
            self.arr_2.append(self.arr_2[0])
            self.arr_2.remove(self.arr_2[0])

    def crypt(self):
        msg = input("Введите сообщение для шифрования: ").lower()
        key = int(input("Введите ключ шифрования: "))
        self.change_alph(key)
        msgc = ""

        for i in msg:
            for j in range(len(self.arr_1)):
                if i == self.arr_1[j]:
                    msgc += self.arr_2[j]

        print("Зашифрованное сообщение: " + msgc)

    def decrypt(self):
        msg = input("Введите сообщение для дешифрования: ").lower()
        key = int(input("Введите ключ шифрования: "))
        self.change_alph(key)
        msgd = ""

        for i in msg:
            for j in range(len(self.arr_1)):
                if i == self.arr_2[j]:
                    msgd += self.arr_1[j]

        print("Исходное сообщение: " + msgd)


    def main(self):
        print("Введите 1 для шифрования сообщения")
        print("Введите 2 для дешифрования сообщения")
        act = int(input())
        if act==1:
            self.crypt()
        else:
            self.decrypt()

if __name__ == "__main__":
    A = CaesarCipher()
    A.main()