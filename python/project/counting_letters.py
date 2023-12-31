#Letters Counter

def count_letters(text):
    
    letters_counter = {}

    for letter in text:
        if letter.isalpha():  
            letter = letter.lower()  
            letters_counter[letter] = letters_counter.get(letter, 0) + 1

   
    total_letters = sum(letters_counter.values())

    
    print("Letter\tAppearances\tPercentage")
    for letter, count in letters_counter.items():
        percentage = (count / total_letters) * 100
        print(f"{letter}\t{count}\t{percentage:.2f}%")


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
upon his chest and his hands clasped behind him.
To me, who knew his every mood and habit, his attitude and manner told their own story. He was at
work again. He had risen out of his drug-created
dreams and was hot upon the scent of some new
problem. I rang the bell and was shown up to the
chamber which had formerly been in part my own.
His manner was not effusive. It seldom was;
but he was glad, I think, to see me. With hardly
a word spoken, but with a kindly eye, he waved
me to an armchair, threw across his case of cigars,
and indicated a spirit case and a gasogene in the
corner. Then he stood before the fire and looked
me over in his singular introspective fashion.
“Wedlock suits you,” he remarked. “I think,
Watson, that you have put on seven and a half
pounds since I saw you.”
“Seven!” I answered.
“Indeed, I should have thought a little more.
Just a trifle more, I fancy, Watson. And in practice again, I observe. You did not tell me that you
intended to go into harness.”
“Then, how do you know?”
“I see it, I deduce it. How do I know that you
have been getting yourself very wet lately, and that
you have a most clumsy and careless servant girl?”
“My dear Holmes,” said I, “this is too much.
You would certainly have been burned, had you
lived a few centuries ago. It is true that I had a
country walk on Thursday and came home in a
dreadful mess, but as I have changed my clothes I
can’t imagine how you deduce it. As to Mary Jane,
she is incorrigible, and my wife has given her notice, but there, again, I fail to see how you work it
out.”
He chuckled to himself and rubbed his long,
nervous hands together.
“It is simplicity itself,” said he; “my eyes tell
me that on the inside of your left shoe, just where'''

count_letters(example)
