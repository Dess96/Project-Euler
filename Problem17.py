#Problem 17
#If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total. 
#If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

class letters():
    def __init__(self):
        self.list = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
        "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"]
    
    def find_sum(self):
        sum = 0
        for i in range(19, len(self.list)): #concatenar twenty con one, two, etc (igual para thirty, forty, etc)
            for j in range(0, 9):
                string = self.list[i] + self.list[j]
                self.list.append(string)
        self.list.extend(["onehundred", "twohundred", "threehundred", "fourhundred", "fivehundred", "sixhundred", "sevenhundred", "eighthundred", "ninehundred"])
        for i in range(99, len(self.list)): #concatenar one hundread con and one, and two, etc (igual para three hundred, four hundred, etc)
            for j in range(0, 99):
                string = self.list[i] + "and" + self.list[j]
                self.list.append(string)
        self.list.append("onethousand")

        for i in range(0, len(self.list)):
            word = self.list[i]
            for j in range(0, len(word)):
                sum += 1
        print("The sum of the letters from one to one thousand is", sum)

if __name__ == "__main__":
    let = letters()
    let.find_sum()
