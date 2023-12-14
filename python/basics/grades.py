import csv

grades_math = []
grades_physics = []
grades_programming = []
grades = []
grades_A = []
grades_B = []
grades_C = []
grades_D = []


filename = 'grades.csv'

with open(filename) as file:
    reader = csv.reader(file)
    header_row = next(reader)

    for row in reader:
            grade = int(row[2])
            grades.append(grade)
            students = row[0]
            subject = row[1]

            if subject == 'math':
                grades_math.append(grade)
            elif subject == 'physics':
                grades_physics.append(grade)
            else:
                grades_programming.append(grade)


'''
    for row in reader:
            grade = int(row[2])
            grades.append(grade)
            students = row[0]
            subject = row[1]

            if students == 'st_A':
                grades_A.append(grade)
            elif students == 'st_B':
                grades_B.append(grade)
            elif students == 'st_D':
                grades_D.append(grade)
            else:
                grades_C.append(grade)
'''
#-----------------------------------------------------------------------------
'''
average_grades_math = round(sum(grades_math)/len(grades_math), 2)
average_grades_physics = round(sum(grades_physics)/len(grades_physics), 2)
average_grades_programming = round(sum(grades_programming)/len(grades_programming), 2)
'''
#-----------------------------------------------------------------------------
'''
average_student_A = round(sum(grades_A)/len(grades_A), 2)
average_student_B = round(sum(grades_B)/len(grades_B), 2)
average_student_C = round(sum(grades_C)/len(grades_C), 2)
average_student_D = round(sum(grades_D)/len(grades_D), 2)
'''
#-----------------------------------------------------------------------------
'''
print("The average math grades is:", average_grades_math)
print("The average physics grades is:", average_grades_physics)
print("The average programming grades is:", average_grades_programming)
'''
#-----------------------------------------------------------------------------

num_math = len(grades_math)
num_physics = len(grades_physics)
num_programming = len(grades_programming)


print("There are:", num_math, "grades for Math subject")
print("There are:", num_physics, "grades for Physics subject")
print("There are:", num_programming, "grades for Programming subject")

#-----------------------------------------------------------------------------

import matplotlib.pyplot as plt
'''       
#plt.style.use('seaborn')    # estilo de la grafica
fig, ax = plt.subplots()     # es una especie de contenedor

bar_colors = ['tab:red', 'tab:blue', 'tab:green', 'tab:pink']
averages = [average_student_A, average_student_B, average_student_C, average_student_D]
student = ['A', 'B', 'C', 'D']

ax.bar(student, averages, color = bar_colors, width = 0.4)
ax.set_ylabel('Average grades')
ax.set_title('Average grades for students')
'''

num_grades = [num_math, num_physics, num_programming]
subjects = ["Math", "Physics", "Programming"]
grafic_colors = ["#F7DC6F", "#48C9B0", "#C0392B"]
separacion = [0.05, 0, 0]

plt.pie(num_grades, labels=subjects, autopct="%0.1f %%", colors=grafic_colors, explode=separacion)
plt.axis("equal")





plt.show()

