#Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right 
#corner. How many such routes are there through a 20×20 grid?

class paths():
    def __init__(self):
        pass

    # This code is contributed by 
    # Sanjit_Prasad 
    def binomialCoeff(self, n, k): #Se usa la formula de coeficiente binomial porque los "caminos" en realidad las distintas combinaciones de 
        #posiciones posibles
        C = [[0 for i in range(k+1)]for i in range(n+1)] 
        for i in range(0,n+1,1): 
            for j in range(0,min(i, k)+1,1):
                if (j == 0 or j == i): 
                    C[i][j] = 1
                else: 
                    C[i][j] = C[i - 1][j - 1] + C[i - 1][j] 
        return C[n][k] 
  
if __name__ == '__main__': 
    path = paths()
    n = 40
    i = 20
    print("Total number of different ways are", path.binomialCoeff(n, i)) 
    
