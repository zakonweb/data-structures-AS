Module StackControl
    Dim Queue(6) As Char
    Dim Head, Tail As Integer

    Sub Main()
        Dim choice As Integer
        Dim Value As Char

        Initialise()
        Do
            Console.Clear()
            Console.WriteLine("Queue Data Structure. (FIFO)")
            Console.WriteLine("1. Insert to Q.")
            Console.WriteLine("2. Delete from Q.")
            Console.WriteLine("3. Exit program.")
            Do
                Console.Write("Enter your choice 1..3 : ")
                choice = Console.ReadLine
            Loop Until choice >= 1 And choice <= 3

            Select Case choice
                Case 1
                    Console.Write("Enter character to insert on Q: ")
                    Value = Console.ReadLine
                    Call EnQueue(Value)
                    Call displayQ()
                Case 2
                    Value = DeQueue()
                    If Trim(Value) = "" Then
                        Console.WriteLine("Underflow, Q is empty. No values to pop.")
                        Console.ReadKey()
                    Else
                        Console.WriteLine("Queue Value Deleted : " & Value)
                        Console.ReadKey()
                    End If
                    Call displayQ()
            End Select
        Loop Until choice = 3

    End Sub

    Sub EnQueue(ByVal data As Char)
        If Tail = 6 Then
            Console.WriteLine("Overflow, Queue is full. No more values can be added.")
            Console.ReadKey()
        Else
            Tail = Tail + 1
            Queue(Tail) = data
        End If
    End Sub

    Function DeQueue() As Char
        Dim data As Char

        If Head = Tail Then
            data = ""
        Else
            Head = Head + 1
            data = Queue(Head)
        End If

        Return data
    End Function

    Sub Initialise()
        Dim i As Integer
        For i = 1 To 6
            Queue(i) = ""
        Next
        Head = 0
        Tail = 0
    End Sub

    Sub displayQ()
        Dim i As Integer
        Console.WriteLine("")
        Console.WriteLine("Head Pointer = " & Head)
        Console.WriteLine("Tail Pointer = " & Tail)
        Console.WriteLine("")
        Console.WriteLine("Tail Pointer")
        For i = 1 To 6
            If i = Tail Then
                Console.WriteLine("T")
                Exit For
            Else
                Console.Write(" ")
            End If
        Next

        For i = 1 To 6
            Console.Write(Queue(i))
            If i = 6 Then Console.WriteLine("")
        Next

        For i = 1 To 6
            If i = Head Then
                Console.WriteLine("H")
                Exit For
            Else
                Console.Write(" ")
            End If
            If i = 6 Then Console.WriteLine("")
        Next
        Console.WriteLine("Head Pointer")
        Console.ReadKey()
    End Sub
End Module