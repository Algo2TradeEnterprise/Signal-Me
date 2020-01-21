Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class InstrumentDetails
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    <Display(Name:="Instrument Name", Order:=0, AutoGenerateField:=True)>
    Public Property OriginatingInstrument As String

    <Display(Name:="Cash Trading Symbol", Order:=1, AutoGenerateField:=False)>
    Public Property CashTradingSymbol As String

    <Display(Name:="Instrument Token", Order:=2, AutoGenerateField:=False)>
    Public Property CashInstrumentToken As String

    <System.ComponentModel.Browsable(False)>
    Public Property OptionInstruments As Dictionary(Of String, OptionInstrumentDetails)
    <System.ComponentModel.Browsable(False)>
    Public Property PEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)
    <System.ComponentModel.Browsable(False)>
    Public Property CEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)


    <Display(Name:="Open", Order:=3, AutoGenerateField:=True)>
    Public Property Open As Decimal

    <Display(Name:="Low", Order:=4, AutoGenerateField:=True)>
    Public Property Low As Decimal

    <Display(Name:="High", Order:=5, AutoGenerateField:=True)>
    Public Property High As Decimal

    <Display(Name:="Close", Order:=6, AutoGenerateField:=True)>
    Public Property Close As Decimal

    <Display(Name:="Volume", Order:=7, AutoGenerateField:=True)>
    Public Property Volume As Decimal

    <Display(Name:="LTP", Order:=8, AutoGenerateField:=True)>
    Public Property LTP As Decimal

    <Display(Name:="Previous Close", Order:=9, AutoGenerateField:=True)>
    Public Property PreviousClose As Decimal

    <Display(Name:="Change %", Order:=10, AutoGenerateField:=True)>
    Public ReadOnly Property ChangePer As Decimal
        Get
            If LTP <> Decimal.MinValue AndAlso PreviousClose <> Decimal.MinValue AndAlso LTP <> 0 Then
                Return Math.Round(((PreviousClose / LTP) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="ATR", Order:=11, AutoGenerateField:=False)>
    Public Property ATR As Decimal

    <Display(Name:="Slab", Order:=12, AutoGenerateField:=False)>
    Public Property Slab As Decimal

    <Display(Name:="Sum of Puts OI", Order:=13, AutoGenerateField:=True)>
    Public Property SumOfPutsOI As Decimal

    <Display(Name:="Sum of Calls OI", Order:=14, AutoGenerateField:=True)>
    Public Property SumOfCallsOI As Decimal

    <Display(Name:="CPC %", Order:=15, AutoGenerateField:=True)>
    Public ReadOnly Property CPC As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> 0 Then
                Return Math.Round(((SumOfCallsOI / SumOfPutsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="PCC %", Order:=16, AutoGenerateField:=True)>
    Public ReadOnly Property PCC As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue AndAlso SumOfCallsOI <> 0 Then
                Return Math.Round(((SumOfPutsOI / SumOfCallsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="CTR %", Order:=17, AutoGenerateField:=True)>
    Public ReadOnly Property CTR As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue AndAlso (SumOfCallsOI + SumOfPutsOI) <> 0 Then
                Return Math.Round((SumOfCallsOI / (SumOfCallsOI + SumOfPutsOI)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="PTR %", Order:=18, AutoGenerateField:=True)>
    Public ReadOnly Property PTR As Decimal
        Get
            If SumOfCallsOI <> Decimal.MinValue AndAlso SumOfPutsOI <> Decimal.MinValue AndAlso (SumOfCallsOI + SumOfPutsOI) <> 0 Then
                Return Math.Round((SumOfPutsOI / (SumOfCallsOI + SumOfPutsOI)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="Last Update Time", Order:=19, AutoGenerateField:=True)>
    Public Property LastUpdateTime As Date
End Class
