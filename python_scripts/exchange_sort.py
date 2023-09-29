import ast
print("The matrix:",end=" ")
list = ast.literal_eval(input())

def exchange_sort(list):
    for i in range(len(list)):
        for j in range(i + 1,len(list)):
            if list[i] > list[j]:
                list[i] , list[j] = list[j] , list[i]
    return list

print(exchange_sort(list))

# test1: [2,8,9,15,12,11,20]

