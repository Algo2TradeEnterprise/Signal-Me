Public Class InstrumentDetails
    Public Property OriginatingInstrument As String
    Public Property CashTradingSymbol As String
    Public Property CashInstrumentToken As String
    Public Property OptionInstruments As Dictionary(Of String, OptionInstrumentDetails)
    Public Property PEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)
    Public Property CEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)
    Public Property Open As Decimal
    Public Property Low As Decimal
    Public Property High As Decimal
    Public Property Close As Decimal
    Public Property Volume As Decimal
    Public Property LTP As Decimal
    Public Property PreviousClose As Decimal
    Public Property SumOfPutsOI As Decimal
    Public Property SumOfCallsOI As Decimal
    Public ReadOnly Property CPC As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue Then
                Return Math.Round(((SumOfCallsOI / SumOfPutsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property PCC As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue Then
                Return Math.Round(((SumOfPutsOI / SumOfCallsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property
End Class
