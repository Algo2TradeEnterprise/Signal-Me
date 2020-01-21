Imports NLog
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class InstrumentDetails
    Implements INotifyPropertyChanged

#Region "Logging and Status Progress"
    Public Shared logger As Logger = LogManager.GetCurrentClassLogger
#End Region

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Sub NotifyPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    <Display(Name:="Instrument Name", Order:=0, AutoGenerateField:=True)>
    Public Property OriginatingInstrument As String

    Private _LastUpdateTime As Date
    <Display(Name:="Last Update Time", Order:=1, AutoGenerateField:=True)>
    Public Property LastUpdateTime As Date
        Get
            Return _LastUpdateTime
        End Get
        Set(value As Date)
            If _LastUpdateTime <> value Then
                _LastUpdateTime = value

                logger.Fatal(Me.ToString)
            End If
        End Set
    End Property

    <Display(Name:="LTP", Order:=2, AutoGenerateField:=True)>
    Public Property LTP As Decimal

    <Display(Name:="Change %", Order:=3, AutoGenerateField:=True)>
    Public ReadOnly Property ChangePer As Decimal
        Get
            If LTP <> Decimal.MinValue AndAlso PreviousClose <> Decimal.MinValue AndAlso LTP <> 0 Then
                Return Math.Round(((PreviousClose / LTP) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="ATR %", Order:=4, AutoGenerateField:=True)>
    Public Property ATR As Decimal

    <Display(Name:="Slab", Order:=5, AutoGenerateField:=True)>
    Public Property Slab As Decimal

    <Display(Name:="Sum of Puts OI", Order:=6, AutoGenerateField:=True)>
    Public Property SumOfPutsOI As Long

    <Display(Name:="Sum of Calls OI", Order:=7, AutoGenerateField:=True)>
    Public Property SumOfCallsOI As Long

    <Display(Name:="OI CPC %", Order:=8, AutoGenerateField:=True)>
    Public ReadOnly Property OICPC As Decimal
        Get
            If SumOfCallsOI <> Long.MinValue AndAlso SumOfPutsOI <> Long.MinValue AndAlso SumOfPutsOI <> 0 Then
                Return Math.Round(((SumOfCallsOI / SumOfPutsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI PCC %", Order:=9, AutoGenerateField:=True)>
    Public ReadOnly Property OIPCC As Decimal
        Get
            If SumOfCallsOI <> Long.MinValue AndAlso SumOfPutsOI <> Long.MinValue AndAlso SumOfCallsOI <> 0 Then
                Return Math.Round(((SumOfPutsOI / SumOfCallsOI) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI CTR %", Order:=10, AutoGenerateField:=True)>
    Public ReadOnly Property OICTR As Decimal
        Get
            If SumOfCallsOI <> Long.MinValue AndAlso SumOfPutsOI <> Long.MinValue AndAlso (SumOfCallsOI + SumOfPutsOI) <> 0 Then
                Return Math.Round((SumOfCallsOI / (SumOfCallsOI + SumOfPutsOI)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI PTR %", Order:=11, AutoGenerateField:=True)>
    Public ReadOnly Property OIPTR As Decimal
        Get
            If SumOfCallsOI <> Long.MinValue AndAlso SumOfPutsOI <> Long.MinValue AndAlso (SumOfCallsOI + SumOfPutsOI) <> 0 Then
                Return Math.Round((SumOfPutsOI / (SumOfCallsOI + SumOfPutsOI)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="", Order:=12, AutoGenerateField:=True)>
    Public Property Seperator1 As String

    <Display(Name:="Sum of Puts OI Change", Order:=13, AutoGenerateField:=True)>
    Public Property SumOfPutsOIChange As Long

    <Display(Name:="Sum of Calls OI Change", Order:=14, AutoGenerateField:=True)>
    Public Property SumOfCallsOIChange As Long

    <Display(Name:="OI Change CPC %", Order:=15, AutoGenerateField:=True)>
    Public ReadOnly Property OIChangeCPC As Decimal
        Get
            If SumOfCallsOIChange <> Long.MinValue AndAlso SumOfPutsOIChange <> Long.MinValue AndAlso SumOfPutsOIChange <> 0 Then
                Return Math.Round(((SumOfCallsOIChange / SumOfPutsOIChange) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI Change PCC %", Order:=16, AutoGenerateField:=True)>
    Public ReadOnly Property OIChangePCC As Decimal
        Get
            If SumOfCallsOIChange <> Long.MinValue AndAlso SumOfPutsOIChange <> Long.MinValue AndAlso SumOfCallsOIChange <> 0 Then
                Return Math.Round(((SumOfPutsOIChange / SumOfCallsOIChange) - 1) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI Change CTR %", Order:=17, AutoGenerateField:=True)>
    Public ReadOnly Property OIChangeCTR As Decimal
        Get
            If SumOfCallsOIChange <> Long.MinValue AndAlso SumOfPutsOIChange <> Long.MinValue AndAlso (SumOfCallsOIChange + SumOfPutsOIChange) <> 0 Then
                Return Math.Round((SumOfCallsOIChange / (SumOfCallsOIChange + SumOfPutsOIChange)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property

    <Display(Name:="OI Change PTR %", Order:=18, AutoGenerateField:=True)>
    Public ReadOnly Property OIChangePTR As Decimal
        Get
            If SumOfCallsOIChange <> Long.MinValue AndAlso SumOfPutsOIChange <> Long.MinValue AndAlso (SumOfCallsOIChange + SumOfPutsOIChange) <> 0 Then
                Return Math.Round((SumOfPutsOIChange / (SumOfCallsOIChange + SumOfPutsOIChange)) * 100, 2)
            Else
                Return 0
            End If
        End Get
    End Property


#Region "Non Relevant"
    <Display(Name:="", Order:=50, AutoGenerateField:=True)>
    Public Property Seperator50 As String

    <Display(Name:="Open", Order:=51, AutoGenerateField:=True)>
    Public Property Open As Decimal

    <Display(Name:="Low", Order:=52, AutoGenerateField:=True)>
    Public Property Low As Decimal

    <Display(Name:="High", Order:=53, AutoGenerateField:=True)>
    Public Property High As Decimal

    <Display(Name:="Close", Order:=54, AutoGenerateField:=True)>
    Public Property Close As Decimal

    <Display(Name:="Volume", Order:=55, AutoGenerateField:=True)>
    Public Property Volume As Decimal
#End Region

#Region "Non Browsable"
    <Display(Name:="Previous Close", Order:=100, AutoGenerateField:=False)>
    Public Property PreviousClose As Decimal

    <Display(Name:="Cash Trading Symbol", Order:=100, AutoGenerateField:=False)>
    Public Property CashTradingSymbol As String

    <Display(Name:="Instrument Token", Order:=100, AutoGenerateField:=False)>
    Public Property CashInstrumentToken As String

    <System.ComponentModel.Browsable(False)>
    Public Property OptionInstruments As Dictionary(Of String, OptionInstrumentDetails)
    <System.ComponentModel.Browsable(False)>
    Public Property PEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)
    <System.ComponentModel.Browsable(False)>
    Public Property CEInstrumentsPayloads As Concurrent.ConcurrentDictionary(Of String, Payload)
#End Region

    Public Overrides Function ToString() As String
        Return String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24}",
                             Me.OriginatingInstrument, Me.LastUpdateTime.ToString("HH:mm:ss"), Me.LTP, Me.ChangePer, Me.ATR, Me.Slab,
                             Me.SumOfPutsOI, Me.SumOfCallsOI, Me.OICPC, Me.OIPCC, Me.OICTR, Me.OIPTR, "",
                             Me.SumOfPutsOIChange, Me.SumOfCallsOIChange, Me.OIChangeCPC, Me.OIChangePCC, Me.OIChangeCTR, Me.OIChangePTR, "",
                             Me.Open, Me.Low, Me.High, Me.Close, Me.Volume)
    End Function

End Class
