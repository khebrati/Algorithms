import ast
print("Enter the first Matrix:",end=" ")
matrix1 = ast.literal_eval(input())
print("Enter the second Matrix:",end=" ")
matrix2 = ast.literal_eval(input())


def add_matrix(matrix1,matrix2):
    output_matrix = []
    for row in range(len(matrix1)):
        output_matrix.append([])
        for col in range(len(matrix1[row])):
            output_matrix[row].append([None])
            output_matrix[row][col] = matrix1[row][col] + matrix2[row][col]
    return output_matrix


print(add_matrix(matrix1,matrix2))

# [[1,2,3],[4,5,6],[7,8,9]]

# [[-1,-2,-3],[-4,-5,-6],[-7,-8,-9]]