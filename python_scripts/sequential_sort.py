import ast

def sequential_search(list,item):
    for index,element in enumerate(list):
        if element == item:
            return index
    return -1
        

print("The list:",end=" ")
list = ast.literal_eval(input())
print("The item to look for:",end=" ")
item = ast.literal_eval(input())

print(f"It's in the index {sequential_search(list,item)}")

