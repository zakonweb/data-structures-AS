Module Module1
    Dim Stack(4) As Char
    Dim ToS As Integer

    Sub Main()
        Dim item As Char
        Dim menuChoice As Integer

        Call CreateStack()
        Do 'REPEAT
            Console.WriteLine("1. Push")
            Console.WriteLine("2. Pop")
            Console.WriteLine("3. Display stack")
            Console.WriteLine("4. Exit")

            Do 'Validation - Range Check
                Console.Write("Enter your option. (1-4):")
                menuChoice = Console.ReadLine
            Loop Until (menuChoice >= 1 And menuChoice <= 4)

            Select Case menuChoice
                Case 1
                    Console.Write("Enter value to push.")
                    item = Console.ReadLine

                    Call Push(item)
                Case 2
                    item = Pop()
                    If item = " " Then
                        Console.WriteLine("Underflow. No item to delete.")
                    Else
                        Console.WriteLine("Item popped = " & item)
                    End If
                    Console.ReadKey()
                Case 3 : Call DisplayStack()
            End Select
        Loop Until (menuChoice = 4)

    End Sub

    Sub CreateStack()
        Dim i As Integer

        'Initialise Stack
        For i = 0 To 4
            Stack(i) = ""
        Next i

        ToS = -1
    End Sub

    Sub Push(X As Char)
        If ToS = 4 Then
            Console.WriteLine("Overflow occured, no more values can be pushed.")
            Console.ReadKey()
        Else
            ToS = ToS + 1
            Stack(ToS) = X
        End If
    End Sub

    Function Pop() As Char
        Dim Value As Char
        Value = " "

        If ToS <> -1 Then
            Value = Stack(ToS)
            ToS = ToS - 1
        End If
        Return Value
    End Function

    Sub DisplayStack()
        Dim i As Integer
        For i = 4 To 0 Step -1
            If i = ToS Then
                Console.WriteLine(Stack(i) & "    <----")
            Else
                Console.WriteLine(Stack(i))
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
