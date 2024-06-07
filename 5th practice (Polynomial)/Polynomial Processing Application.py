from numpy import zeros, delete
class Polynomial():

    def __init__(self):
        self.non_zero = 0
        self.polynomial_array = zeros(0) 

    def set_non_zero (self, n):
        self.non_zero = n
        
    def read_from_keyboard(self):
        self.non_zero = int(input("Please tell me how many non-zero monomial do you have? "))
        self.polynomial_array = zeros((2, self.non_zero)) 
        print("Please give me your polynomial in this format (coefficient , exponent): \n")
        for i in range(self.non_zero):
            self.polynomial_array[0][i] = int(input("give me the coefficient for monomial number {0} : ".format(i+1)))
            self.polynomial_array[1][i] = int(input("give me the exponent for monomial number {0} : ".format(i+1)))

    def read_from_file(self):
        try:  
            # 'D:/Education/Data Structure/Project/5th practice (Polynomial)/InputData_a.txt'
            # 'D:/Education/Data Structure/Project/5th practice (Polynomial)/InputData_b.txt'
            file = open(input(),'r')
            try:
                self.non_zero = int(file.readline())
                self.polynomial_array = zeros((2, self.non_zero)) 
                for i in range(self.non_zero):
                    line = [int(i) for i in next(file).split()]
                    self.polynomial_array[0][i] , self.polynomial_array[1][i] = line[0], line[1]
                return("Polynomial was read from file successfully.\n")
            except:
                return("An error occurred during reading from input file!")
        except:
            return("An error occurred during opening the input file!")
    
    def evaluate(self):
        x_value = float(input("Please tell me the value of x : "))
        value = 0.0
        for i in range(self.non_zero):
            value += self.polynomial_array[0][i] * x_value ** self.polynomial_array[1][i]
        return value
    
    def show_on_screen(self):
        polynomial_string = ""
        for i in range(self.non_zero):
            polynomial_string += str(self.polynomial_array[0][i]) + "*X^" + str(int(self.polynomial_array[1][i])) + " "
        return polynomial_string
    
    def save_in_file(self):
        try:            
            file = open(input(),"w")
            try:    
                file.write(self.show_on_screen()+"\n")
                return("Polynomial was written to file successfully.\n")
            except:
                return("An error occurred during writing to output file!\n")
        except:
            return("An error occurred during opening the output file!\n")
    
    def addition(self, b):
        c = Polynomial()
        c.set_non_zero(self.non_zero + b.non_zero)
        c.polynomial_array = self.concatenate(self.polynomial_array, self.non_zero, b.polynomial_array, b.non_zero)
        for i in range(c.non_zero -1):
            for j in range(i+1, c.non_zero):
                if c.polynomial_array[1][i] == c.polynomial_array[1][j]:
                    c.polynomial_array[0][i] += c.polynomial_array[0][j]
                    c.polynomial_array[0][j] = 0
        c.sort()
        return c
    
    def concatenate(self, array1 = zeros(0), n1 = int(), array2= zeros(0), n2 = int()):
        concatenated_array = zeros((2, int(n1+n2)))
        for i in range(n1):
            concatenated_array[0][i], concatenated_array[1][i] = array1[0][i], array1[1][i]
        for i in range(n2):
            concatenated_array[0][i+n1], concatenated_array[1][i+n1] = array2[0][i], array2[1][i]
        return concatenated_array
    
    def delete_zeros(self):
            i = 0
            while(i!=self.non_zero):
                if (self.polynomial_array[0][i] == 0):
                    self.non_zero -= 1
                    self.polynomial_array = delete(self.polynomial_array, i ,  axis = 1)
                    i-=1
                i+=1

    def sort(self):
        for i in range(self.non_zero-1):
            for j in range(0, self.non_zero-i-1):
                if self.polynomial_array[1][j] < self.polynomial_array[1][j + 1]:
                    self.polynomial_array[1][j], self.polynomial_array[1][j+1] = self.polynomial_array[1][j + 1], self.polynomial_array[1][j]
                    self.polynomial_array[0][j], self.polynomial_array[0][j+1] = self.polynomial_array[0][j + 1], self.polynomial_array[0][j]
                    
                    
                    
                    
                    
print("Please give me the directory of polynomial a: ")    
a = Polynomial()
a.read_from_file()             # 'D:/Education/Data Structure/Project/5th practice (Polynomial)/InputData_a.txt'
print(a.polynomial_array)
print(a.show_on_screen())
print("Please give me the directory of polynomial b: ") 
b = Polynomial()
b.read_from_file()             # 'D:/Education/Data Structure/Project/5th practice (Polynomial)/InputData_b.txt'
print(b.polynomial_array)
print(b.show_on_screen())
print("The addition of a and b is: ", end= "\n")
c= a.addition(b)
c.delete_zeros()
print(c.polynomial_array)
print("Evaluation of c :")
print(c.evaluate())
print("Please give me a directory to save a+b :")
c.save_in_file()                 # "D:/Education/Data Structure/Project/5th practice (Polynomial)/OutputData.txt"