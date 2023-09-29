def multiply_matrix(matrixA,matrixB):
    result_matrix = []
    for rowA in range(len(matrixA)):
        result_matrix.append([])
        for colB in range(len(matrixB[0])):
            sum = 0
            for colA_and_rowB in range(len(matrixB)):
                sum =+ matrixA[rowA][colA_and_rowB] + matrixB[colA_and_rowB][colB]
            result_matrix[rowA].append(sum)
    return result_matrix


print(multiply_matrix(
    [[1,2,3],[4,5,6]],
    [[-1,-2,-3],[-4,-5,-6]]
))