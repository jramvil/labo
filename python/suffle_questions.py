import random
import os

def make_test(title):

    f = open('the_test.txt', 'w')

    Q = ['Q1', 'Q2', 'Q3', 'Q4', 'Q5']


    ANS_1 = ['ans_1a', 'ans_1b', 'ans_1c', 'ans_1d']
    ANS_2 = ['ans_2a', 'ans_2b', 'ans_2c', 'ans_2d']
    ANS_3 = ['ans_3a', 'ans_3b', 'ans_3c', 'ans_3d']
    ANS_4 = ['ans_4a', 'ans_4b', 'ans_4c', 'ans_4d']
    ANS_5 = ['ans_5a', 'ans_5b', 'ans_5c', 'ans_5d']


    QS = random.sample(Q, len(Q)) 
    AS1 = random.sample(ANS_1, len(ANS_1))
    AS2 = random.sample(ANS_2, len(ANS_2))
    AS3 = random.sample(ANS_3, len(ANS_3))
    AS4 = random.sample(ANS_4, len(ANS_4))
    AS5 = random.sample(ANS_5, len(ANS_5))

    
    i = 0
    options = ['a', 'b', 'c', 'd']

    print(title + '\n')
    f.write(title + '\n\n')

    for q in QS:
        i+=1
        line = str(i)+') ' + q+"......................."

        f.write('\n'+line+'\n')
        print('\n'+line)
        j = 0
        
        if(q == 'Q1'):
            for a in AS1:
                line = "      " +options[j]+') ' + a
                print(line)
                f.write(line+'\n')
                j += 1
        elif(q == 'Q2'):
            for a in AS2:
                line = "      " +options[j]+') ' + a
                print(line)
                f.write(line+'\n')
                j += 1
        elif(q == 'Q3'):
            for a in AS3:
                line = "      " +options[j]+') ' + a
                print(line)
                f.write(line+'\n')
                j += 1
        elif(q == 'Q4'):
            for a in AS4:
                line = "      " +options[j]+') ' + a
                print(line)
                f.write(line+'\n')
                j += 1
        else:
            for a in AS5:
                line = "      " +options[j]+') ' + a
                print(line)
                f.write(line+'\n')
                j += 1
        


def print_test(n):
    
    for i in range(n):
        make_test('Test Scrum, 2023-01-31')
        os.rename('the_test.txt', 'test'+str(i)+'.txt')








print_test(2)

