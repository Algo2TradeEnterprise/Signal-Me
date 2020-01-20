Public Class InstrumentDetails
    Public Property OriginatingInstrument As String
    Public Property CashTradingSymbol As String
    Public Property CashInstrumentToken As String
    Public Property OptionInstruments As Dictionary(Of String, OptionInstrumentDetails)
    Public Property PEInstrumentsPayloads As Dictionary(Of String, Dictionary(Of Date, Payload))
    Public Property CEInstrumentsPayloads As Dictionary(Of String, Dictionary(Of Date, Payload))
    Public Property Open As Decimal
    Public Property Low As Decimal
    Public Property High As Decimal
    Public Property Close As Decimal
    Public Property Volume As Decimal
    Public Property LTP As Decimal
    Public Property PreviousClose As Decimal
End Class
