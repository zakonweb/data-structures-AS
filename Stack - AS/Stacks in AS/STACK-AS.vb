Module StackControl
    Dim Stack(6) As Char
    Dim TopOfStackPointer As Integer

    Sub Main()
        Dim choice As Integer
        Dim Value As Char

        Initialise()
        Do
            Console.Clear()
            Console.WriteLine("1. Push to stack.")
            Console.WriteLine("2. Pop from stack.")
            Console.WriteLine("3. Exit program.")
            Do
                Console.Write("Enter your choice 1..3 : ")
                choice = Console.ReadLine
            Loop Until choice >= 1 And choice <= 3

            Select Case choice
                Case 1
                    Console.Write("Enter character to push on stack: ")
                    Value = Console.ReadLine
                    Call Push(Value)
                    Call displayStack()
                Case 2
                    Value = Pop()
                    If Value = "" Then
                        Console.WriteLine("Underflow, Stack is empty. No values to pop.")
                        Console.ReadKey()
                    Else
                        Console.WriteLine("Stack Value Poped : " & Value)
                        Console.ReadKey()
                    End If
                    Call displayStack()
            End Select
        Loop Until choice = 3

    End Sub

    Sub Push(data As Char)
        If TopOfStackPointer = 6 Then
            Console.WriteLine("Overflow, Stack is full. No more values can be added.")
            Console.ReadKey()
        Else
            TopOfStackPointer = TopOfStackPointer + 1
            Stack(TopOfStackPointer) = data
        End If
    End Sub

    Function Pop() As Char
        Dim data As Char

        If TopOfStackPointer = 0 Then
            data = ""
        Else
            data = Stack(TopOfStackPointer)
            TopOfStackPointer = TopOfStackPointer - 1
        End If

        Return data
    End Function

    Sub Initialise()
        Dim i As Integer
        For i = 1 To 6
            Stack(i) = ""
        Next
        TopOfStackPointer = 0
    End Sub

    Sub displayStack()
        Dim i As Integer
        Console.WriteLine("Top of stack pointer = " & TopOfStackPointer)

        For i = 6 To 1 Step -1
            If i = TopOfStackPointer Then
                Console.WriteLine(Stack(i) & "  <---")
            Else
                Console.WriteLine(Stack(i))
            End If
        Next
        Console.ReadKey()
    End Sub
End Module