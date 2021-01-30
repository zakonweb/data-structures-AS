Module Module1
    'QUEUE ADT (Adjusting Queues)
    Dim FrontPtr, RearPtr, Qsize, UB As Integer
    Dim Queue(5) As Char

    Sub Main()
        Dim x As Char
        x = ""

        Call initialseQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Dequeue()
        Dequeue()
        displayQ()

        Console.Write("Enter data to add in queue: ")
        x = Console.ReadLine
        Enqueue(x)
        displayQ()

        Console.ReadKey()

    End Sub

    Sub initialseQ()
        Dim i As Integer

        FrontPtr = 0
        RearPtr = 0
        Qsize = 0
        UB = 5

        For i = 1 To UB
            Queue(i) = ""
        Next
    End Sub

    Sub Enqueue(data As Char)
        If RearPtr = UB Then
            Console.WriteLine("Error, Overflow occured.")
        Else
            RearPtr = RearPtr + 1
            Queue(RearPtr) = data

            Qsize = Qsize + 1
        End If
    End Sub

    Sub Dequeue()
        If RearPtr = 0 Then
            Console.WriteLine("Error, Underflow occured.")
        Else
            FrontPtr = FrontPtr + 1
            Console.WriteLine(Queue(FrontPtr))

            For i = 1 To UB - 1
                Queue(i) = Queue(i + 1)
            Next

            FrontPtr = FrontPtr - 1
            RearPtr = RearPtr - 1
            Qsize = Qsize - 1
        End If
    End Sub

    Sub displayQ()
        Dim i As Integer

        Console.WriteLine()
        Console.WriteLine("Front Pointer = " & FrontPtr)
        Console.WriteLine("Rear Pointer = " & RearPtr)
        Console.WriteLine("Queue Size = " & Qsize)

        For i = 1 To UB
            Console.Write(Queue(i) & ", ")
        Next
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Module