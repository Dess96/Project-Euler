#Problema 10
#The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. Find the sum of all the primes below two million.

class Sum_primes():
    def __init__(self):
        pass
    
    def is_prime(self, number):
        prime = True
        i = 3
        if(number % 2 == 0):
            prime = False
        else:
            while(i*i <= number and prime == True):
                if(number % i == 0):
                    prime = False
                i += 2
        return prime

    def find_primes(self):
        sum = 2
        for i in range(3, 2000000):
            if(self.is_prime(i)):
                print("Prime found ", i)
                sum += i
        print("The sum of all primes bellow two million is ", sum)

if __name__ == "__main__":
    prime = Sum_primes()
    prime.find_primes()