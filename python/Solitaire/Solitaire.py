al=['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];
k=26
#Перестановка
def switch(key,m,t):
#В зависимости от расположения Джокеров проводим "Тройной разрез"
    if m<t:
        if (m==0)and(t!=k*2+1):
            key=key[t+1:]+key[m:t+1]
        elif (t==k*2+1)and(m!=0):
            key=key[m:t+1]+key[:m]
        elif (t!=k*2+1)and(m!=0):
            key=key[t+1:]+key[m:t+1]+key[:m]
    else:
        if (t==0)and(m!=k*2+1):
            key=key[m+1:]+key[t:m+1]
        elif (m==k*2+1)and(t!=0):
            key=key[t:m+1]+key[:t]
        elif (m!=k*2+1)and(t!=0):
            key=key[m+1:]+key[t:m+1]+key[:t]
    return key
#Генерация гаммы
def keystream(key,n): 
#Создаём список для хранения гаммы
    st=[]
    t=0
    while t!=n:
#перемещение младшего джокера на 1 позицию вниз колоды
        for i in key[:]:
            if i==k*2+1:
    #Если он окажется последним, то перемещаем его в начало колоды
                if key.index(i)==i:
                    key.remove(i)
                    key.insert(0,i)
                    t=key.index(i)
    #Иначе - на 1 позицию вниз
                else:    
                    p=key.index(i)
                    key.remove(i)
                    key.insert(p+1,i)
                    t=key.index(i)
                break 
    #перемещение старшего джокера на 2 позиции вниз колоды
        m=0
        for i in key[:]:
            if i==k*2+2:
    #Если он окажется предпоследним, то перемещаем его в начало колоды
                if key.index(i)==i-2:
                    key.remove(i)
                    key.insert(0,i)
                    m=key.index(i)
    #Если он окажется последним, то перемещаем его на место второй карты
                elif key.index(i)==i-1:
                    key.remove(i)
                    key.insert(1,i)
                    m=key.index(i)
    #Иначе - на 2 позиции вниз            
                else:    
                    p=key.index(i)
                    key.remove(i)
                    key.insert(p+2,i)
                    m=key.index(i)
                break
#Выполняем “тройной разрез”, то есть меняем карты над первым джокером с картами под вторым джокером
#Здесь “первый” и “второй” относятся к порядку, в котором джокеры встречаются в колоде
        key=switch(key,m,t) 
#Смотрим на последнее число, Отсчитываем такое количество карт от начала колоды
#и помещаем их перед последней картой.
        key=key[key[k*2+1]:k*2+1]+key[0:key[k*2+1]]+[key[k*2+1]]
#Смотрим на 1 число. Отсчитываем такое количество карт после нее и запоминаем это число. 
        if key[0]==k*2+2:
            st.append(key[0])
        else:
            st.append(key[key[0]])
        t+=1
#Переводим нашу гамму из чисел в буквы
    st=ctob(st)
    return st
#Перевод букв в числа              
def btoc(st):
    p=st[:]
    for i in range(len(p)):
        for j in range(len(al)):
            if p[i]==al[j]:
                p[i]=j+1
                break
    return p
#Перевод чисел в буквы
def ctob(st):
    p=st[:]
    for i in range(len(p)):
        for j in range(len(al)):
            if p[i]==j+1:
                p[i]=al[j]
                break
    return p
#Сложение чисел по модулю 26
def addition(st,nt):
    p=st[:]
    for i in range(len(st)):
        p[i]=st[i]+nt[i]
        while p[i]>k:
            p[i]-=k
       
    return p
#Вычитание чисел по модулю 26  
def subtraction(st,nt):
    p=st[:]
    for i in range(len(st)):
        p[i]=st[i]-nt[i]
        while p[i]<0:
            p[i]+=k
    return p   
#Шифрование
def encryption(st,kk):
    p=st[:]
    gb=keystream(kk,len(p))
    sc=btoc(p)
    gc=btoc(gb)
    sgc=addition(sc,gc)
    sgb=ctob(sgc)
    return sgb
#Расшифрование
def decryption(st,kk):
    p=st[:]
    gb=keystream(kk,len(p))
    sc=btoc(p)
    gc=btoc(gb)
    sgc=subtraction(sc,gc)
    sgb=ctob(sgc)
    return sgb     
def main():
    t=0
    print('1.Шифрование\n2.Расшифрование\n3.Выход')
    while t!=3:
        t=int(input('Выберите действие: '))
        if t==1:
            file=input('Введите путь к файлу с колодой карт: ')
            kk=[int(line.strip()) for line in open(file)]
            st=[s for s in input('Введите текст, который необходимо зашифровать: ').replace(' ', '').upper()]
            pp=encryption(st,kk[:])
            print(pp)
        elif t==2:
            file=input('Введите путь к файлу с колодой карт: ')
            kk=[int(line.strip()) for line in open(file)]
            st=[s for s in input('Введите текст, который необходимо расшифровать: ').replace(' ', '').upper()]
            tt=decryption(st,kk[:])
            print(tt)
if __name__=='__main__':
    main()
    

    
