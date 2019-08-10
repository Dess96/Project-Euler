#215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26. What is the sum of the digits of the number 21000?

class power_sum():
    def __init__(self):
        pass

    def find_sum(self):
        n = 1000
        number = 2 ** n
        number_string = str(number)
        sum = 0
        for i in number_string:
            sum += int(i)
        print("The sum of the digits of 2^1000 is", sum)

    
if __name__ == "__main__":
    pow = power_sum()
    pow.find_sum()