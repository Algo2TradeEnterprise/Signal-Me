Public Class OptionInstrumentDetails
    Public Property TradingSymbol As String
    Public Property InstrumentToken As String
    Public Property Expiry As Date
    Public Property OriginatingInstrumentExpiry As Date
    Public ReadOnly Property InstrumentType As String
        Get
            If Me.TradingSymbol IsNot Nothing Then
                Return Me.TradingSymbol.Substring(Me.TradingSymbol.Count - 2)
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public ReadOnly Property StrikePrice As String
        Get
            If Me.TradingSymbol IsNot Nothing AndAlso Me.Expiry <> Date.MinValue Then
                If Me.OriginatingInstrumentExpiry <> Date.MinValue AndAlso Me.OriginatingInstrumentExpiry = Me.Expiry Then
                    'Monthly contract

                Else
                    'Weekly contract

                End If
            Else
                Return Nothing
            End If
        End Get
    End Property
End Class
