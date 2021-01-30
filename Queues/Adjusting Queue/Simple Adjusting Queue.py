#Setting up the simple adjusting Q
queue = [None for i in range (5)]
ToQ = 4
TailP = -1

def enQ(arr, data):
    global ToQ, TailP
    if TailP == ToQ:
        print("Error - Overflow.")
    else:
        TailP = TailP +1
        arr[TailP] = data

def deQ(arr):
    global TailP, ToQ
    if TailP == -1:
        return - 1
    else:
        x = arr[0]
        for c in range(ToQ):
            arr[c] = arr[c+1]
        TailP = TailP -1
    return x

#main program
print(queue)
enQ(queue,27)
print(queue)
enQ(queue,34)
print(queue)
enQ(queue,93)
print(queue)
enQ(queue,20)
print(queue)

x = deQ(queue)
if x == -1:
    print ("Underflow error, queue is empty")
else:
    print(x, "is removed.")
    print(queue)

enQ(queue,31)
print(queue)
enQ(queue,55)
print(queue)
enQ(queue,65)
print(queue)

x = deQ(queue)
if x == -1:
    print ("Underflow error, queue is empty")
else:
    print(x, " is removed.")
    print(queue)

enQ(queue,75)
print(queue)