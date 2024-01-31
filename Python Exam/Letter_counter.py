#Python Exam
#Javier Ramirez Villalba

letter_a = 0
letter_b = 0
letter_c = 0

example = '''—I was returning from a journey to a patient
(for I had now returned to civil practice), when my
way led me through Baker Street. As I passed the
well-remembered door, which must always be associated in my mind with my wooing, and with
the dark incidents of the Study in Scarlet, I was
seized with a keen desire to see Holmes again, and
to know how he was employing his extraordinary
powers. His rooms were brilliantly lit, and, even as
I looked up, I saw his tall, spare figure pass twice
in a dark silhouette against the blind. He was pacing the room swiftly, eagerly, with his head sunk
upon his chest and his hands clasped behind him.'''

for caracter in example:
        caracter = caracter.lower()

        if caracter == 'a':
            letter_a += 1
        elif caracter == 'b':
            letter_b += 1
        elif caracter == 'c':
            letter_c += 1

print(f'Letter "a" found {letter_a} times')
print(f'Letter "b" found {letter_b} times')
print(f'Letter "c" found {letter_c} times')


import matplotlib.pyplot as plt

fig, ax = plt.subplots()

bar_colors = ['tab:red', 'tab:blue', 'tab:green']

apperances = [letter_a, letter_b, letter_c]
letters = ['a', 'b', 'c']

ax.bar(letters, apperances, color = bar_colors, width = 0.4)
ax.set_ylabel('Letters apperances')
ax.set_title('Number of apperances in a text')