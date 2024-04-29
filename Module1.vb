Imports System.Runtime.CompilerServices

Module Module1

    Sub Main()
        Dim RINICIAL As Integer
        Dim rfinal As Integer
        Dim LISTA As Integer
        Dim repite As Boolean = True
        Do While repite
            Try
                encabezado("BIENVENIDOS......")
                Console.WriteLine("1. ENLISTAR PARES : ")
                Console.WriteLine(".........................................................................")
                Console.WriteLine("2. ENLISTAR IMPARES : ")
                Console.WriteLine(".........................................................................")
                LISTA = Console.ReadLine()
                Console.WriteLine("INTRODUZCA EL RANGO INICIAL: ")
                Console.WriteLine(".........................................................................")
                RINICIAL = Console.ReadLine()
                Console.WriteLine("INTODUZCA EL RANGO FINAL: ")
                Console.WriteLine(".........................................................................")
                rfinal = Console.ReadLine()

                If LISTA = 1 Then
                    Console.WriteLine(listpares(RINICIAL, rfinal))

                ElseIf LISTA = 2 Then
                    Console.WriteLine("lista de numeros impares: {0}", listimpar(RINICIAL, rfinal))
                    Console.ReadKey()
                    repite = False
                

                End If

            Catch ex As System.OverflowException

                Console.WriteLine("te pasaste de verga :v ")

            Catch ex As System.InvalidCastException

                Console.WriteLine("loco dejate de pendejadas son numeros")

            End Try
        Loop

    End Sub
    Function listimpar(rinicial As Integer, rfinal As Integer) As Integer
        Dim i As Integer
        Dim impar, contar As Integer

        For i = rinicial To rfinal
            If i Mod 2 > 0 Then
                impar = i
                contar = impar + 1
                Console.WriteLine("" & impar)
            End If
        Next

        Console.ReadLine()

    End Function
    Function listpares(rinicial As Integer, rfinal As Integer) As Integer
        Dim i As Integer
        For i = rinicial To rfinal
            If i Mod 2 = 0 Then
                Console.WriteLine()
                Console.WriteLine(i)
            End If
        Next
        Return i

    End Function
    Private Sub encabezado(texto As String)

        Console.WriteLine()
        Console.WriteLine("..................................................................")
        Console.WriteLine(texto)
        Console.WriteLine("..................................................................")
        Console.WriteLine()
    End Sub

End Module
