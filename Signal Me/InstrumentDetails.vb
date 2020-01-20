Public Class InstrumentDetails
    Public Property OriginatingInstrument As String
    Public Property CashTradingSymbol As String
    Public Property CashInstrumentToken As String
    Public Property OptionInstruments As Dictionary(Of String, OptionInstrumentDetails)
    Public Property OptionInstrumentsPayloads As Dictionary(Of String, Dictionary(Of Date, Payload))

End Class
