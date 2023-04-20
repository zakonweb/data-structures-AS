"""
write python code for a simple stack adt of characters
"""

# declare stack array; stack
stack = ['' for i in range(10)]

# declare pointers
topOftack = -1

# push character parameter onto stack
def push(item):
    global topOftack
    if topOftack > 9:
        print("Stack full.")
        return -1
    
    topOftack += 1
    stack[topOftack] = item

def pop():
    global topOftack
    if topOftack == -1:
        print("Stack empty.")
        return -1
    
    item = stack[topOftack]
    topOftack -= 1
    return item

def dispaly_stack():
    for i in range(9,-1,-1):
        if i == topOftack:
            print(stack[i], '<----')
        else:
            print(stack[i])

# main menu
option = 0
while option != 4:
    print('1. Push')
    print('2. Pop')
    print('3. Display Stack')
    print('4. Exit')
    option = int(input('Enter option: '))
    if option == 1: 
        item = input("Enter item to push: ")
        push(item)
    elif option == 2:
        item = pop()
        if item != -1:
            print(item)
    elif option == 3:
        dispaly_stack()
    elif option == 4:
        print("Goodbye.")
    else:
        print("Invalid option.")
