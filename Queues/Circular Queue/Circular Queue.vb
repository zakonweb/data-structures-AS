Module Module1
    Dim FrontPtr, RearPtr, Qsize, Qfull, UB As Integer
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
        Qfull = 5
        UB = 5

        For i = 1 To UB
            Queue(i) = ""
        Next
    End Sub

    Sub Enqueue(data As Char)
        If Qsize = Qfull Then
            console.writeline("Error, Overflow occured.")
        Else
            If RearPtr = UB Then
                RearPtr = 1
            Else
                RearPtr = RearPtr + 1
            End If
            Queue(RearPtr) = data
            Qsize = Qsize + 1
        End If
    End Sub

    Sub Dequeue()
        If Qsize = 0 Then
            Console.WriteLine("Error, Underflow occured.")
        Else
            If FrontPtr = UB Then
                FrontPtr = 1
            Else
                FrontPtr = FrontPtr + 1
            End If
            Console.WriteLine(Queue(FrontPtr) & " is deleted from the queue.")
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