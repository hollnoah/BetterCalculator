'Noah Holloway
'RCET 2265
'Spring 2025
'Better Calculator

Option Explicit On
Option Strict On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim letMeOut As Boolean
        Dim userInput As String

        Do
            Do
                'first loop
                Console.WriteLine("Please enter two numbers")
                Console.WriteLine("Enter Q at any time to quit")
                Console.WriteLine("Choose a number")
                userInput = Console.ReadLine()
                Console.WriteLine($"You entered {userInput}")

                Try
                    firstNumber = CInt(userInput)
                    letMeOut = True

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine("Please enter a whole number")
                    Else
                        letMeOut = True
                    End If
                End Try
            Loop Until letMeOut = True

            'second loop
            letMeOut = False 'reset flag
            Do While userInput <> "Q" And letMeOut = False

                Console.WriteLine("Enter another whole number")
                Console.WriteLine("Enter Q to quit")
                userInput = Console.ReadLine()
                Console.WriteLine($"You entered {userInput}")
                Try
                    secondNumber = CInt(userInput)
                    letMeOut = True

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine("Please enter a whole number")
                    Else
                        letMeOut = True
                    End If
                End Try


            Loop

            letMeOut = False

            Do While userInput <> "Q" And letMeOut = False

                Try

                    Console.WriteLine("Choose one of the following options: " & vbNewLine _
           & "1. Add" & vbNewLine _
            & "2. Subtract" & vbNewLine _
            & "3. Multiply" & vbNewLine _
            & "4. Divide")

                    userInput = Console.ReadLine()
                    Console.WriteLine($"You have selected {userInput}")

                    If userInput = "1" Then
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                        letMeOut = True
                    ElseIf userInput = "2" Then
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
                        letMeOut = True
                    ElseIf userInput = "3" Then
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                        letMeOut = True
                    ElseIf userInput = "4" Then
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
                        letMeOut = True
                    End If
                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine("Please enter a whole number")

                    End If
                End Try
            Loop

        Loop Until userInput = "Q"


    End Sub

End Module
