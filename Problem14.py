#Problem 14
#The following iterative sequence is defined for the set of positive integers: n → n/2 (n is even), n → 3n + 1 (n is odd)
#Which starting number, under one million, produces the longest chain?

class collatz():
    def __init__(self):
        pass

    def get_sequence(self):
        i = 13
        gr_size = 0
        gr_n = 0
        while(i < 1000000):
            sequence = i
            seq_size = 0
            
            while(sequence > 1):
                if(sequence % 2 == 0):
                    sequence = sequence / 2
                    #print(sequence)
                else:
                    sequence = sequence * 3 + 1
                    #print(sequence)
                seq_size += 1
            
            if(seq_size > gr_size):
                gr_size = seq_size + 1
                gr_n = i
                print("Greatest size up to now:", gr_size, "given by:", i)
            i += 1
        
        print("The starting number that produces the longest chain is: ", gr_n)

if __name__ == "__main__":
    coll = collatz()
    coll.get_sequence()