$regfile = "m328pdef.dat"

$crystal = 16000000                                          'Define speed
$hwstack = 32                                               ' default use 32 for the hardware stack
$swstack = 10                                               ' default use 10 for the SW stack
$framesize = 40                                             ' default use 40 for the frame space
$baud = 115200

$lib "i2c_twi.lbx"                                         ' we do not use software emulated I2C but the TWI

' ###############################  Constants
Const MPU_Addr_W = &HD0
Const MPU_Addr_R = &HD1
Const HIH_Addr_W = &H4F
Const HIH_Addr_R = &H4E

' ###############################  Procedury
Declare sub Posli(ByVal Pocet as byte)

' ###############################  Porty pre LED a Tlaèidlo
Config POrtd.3 = Input                                      ' Tlacitko
Portd.3 = 1
ddrD.3 = 0
Config Portd.2 = Output                                     ' LED

' ###############################  COM
Config Com1 = 115200 , synchrone = 0 , Parity = None , Stopbits = 1 , Databits = 8
Open "COM1:" For Binary As #1

' ###############################  I2C Init
set portc.5                                                 ' PullUp SCL
set portc.4                                                 ' PullUp SDA
Config Scl = Portc.5                                       ' we need to provide the SCL pin name
Config Sda = Portc.4                                       ' we need to provide the SDA pin name
Config TWI = 200000
I2CInit
open "TWI" For Binary as #2

' ###############################  Interrupts
Disable UTXC
On UTXC Usart_TX
Enable interrupts

' ###############################  MPU6050 Init
'I2Cstart
'I2cwbyte MPU_addr_W
'I2cwbyte &H6B
'I2cwbyte &H0
'I2CStop

Dim TxBuf(20) as Byte , TXBuf_CNT as Byte, TxBuf_Pocet as Byte
Dim I as Byte, PomStr as String * 20, Flag as Byte
Dim Ar(10) as Byte
Dim Tepl as byte , Vlhk as Byte , Dpom as Single , Status as Byte , Wpom as word


'print chr(48) ;

'Print "Zaciatok"
TXBuf(1) = asc("Z") : TXBuf(2) = asc("a") : TXBuf(3) = asc("c") : TXBuf(4) = asc("i")
TXBuf(5) = asc("a") : TXBuf(6) = asc("t") : TXBuf(7) = asc("o") : TXBuf(8) = asc("k")
Posli(8)

Do

'   if pind.3 = 0 then
   Flag = inkey()
   If Flag > 0 Then                                           'we got something

'      toggle portd.2

'      print chr(49) ;
      I2CStart
      I2CWbyte HIH_Addr_R                     ' Adresu HIH Read - Request na meranie
      I2CStop

'      print chr(50) ;
      I2CStart
      I2CWbyte HIH_Addr_W
      I2CRByte Ar(1) , Ack
      I2CRByte Ar(2) , Ack
      I2CRByte Ar(3) , Ack
      I2CRByte Ar(4) , Nack
      I2CStop

      Status = Ar(1) And &B11000000
      TxBuf(1) = Status
      Ar(1) = Ar(1) And &B00111111
      Wpom = MakeInt(Ar(2) , Ar(1))
      Dpom = Wpom
      Dpom = Dpom / &H3FFD
      Dpom = Dpom * 100
      Vlhk = int(Dpom)
      TxBuf(2) = Vlhk

      Wpom = makeint(Ar(4) , Ar(3))
      Shift Wpom , Right , 2
      Dpom = Wpom
      Dpom = Dpom / &H3FFD
      Dpom = Dpom * 165
      Dpom = Dpom - 40
      Tepl = int(Dpom)
      TxBuf(3) = Tepl

      posli(3)

   End If

Loop

End

' ###############################  Prerušenia
Usart_TX:
   UDR = TXBuf(TXBuf_CNT)
   If TXBuf_CNT < TXBuf_Pocet Then
      Incr TXBuf_CNT
   Else
      Disable UTXC
   End If
Return

' ###############################  Procedury
sub Posli(ByVal Pocet as byte)
   TXBuf_CNT = 2
   TxBuf_Pocet = Pocet
   UDR = TXBuf(1)
   Enable UTXC
End Sub