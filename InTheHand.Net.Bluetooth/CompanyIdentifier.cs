﻿// 32feet.NET - Personal Area Networking for .NET
//
// InTheHand.Net.Bluetooth.BluetoothManufacturer
// 
// Copyright (c) 2003-2023 In The Hand Ltd, All rights reserved.
// This source code is licensed under the MIT License

using System;

namespace InTheHand.Net.Bluetooth
{
    /// <summary>
    /// Assigned company identifiers.
    /// </summary>
    /// 
    /// <remarks>See the list at <see href="https://bitbucket.org/bluetooth-SIG/public/src/main/assigned_numbers/company_identifiers/company_identifiers.yaml"/>.</remarks>
    public enum CompanyIdentifier : ushort
    {
        Unknown = 0xffff,

        KEEPEN = 0x0D01,

        Sparkpark = 0x0D00,

        Ergodriven = 0x0CFF,

        ThuleGroup = 0x0CFE,


        WuhanWoncanConstructionTechnologies = 0x0CFD,


        ElectronX = 0x0CFC,


        Tyromotion = 0x0CFB,


        ProtectAnimalsWithSatellites = 0x0CFA,


        Tamblue = 0x0CF9,

        CoreSensing = 0x0CF8,
        /*
        = 0x0CF7
          TVS Motor Company Ltd.

        = 0x0CF6
          OJ Electronics A/S

        = 0x0CF5
          BOS Balance of Storage Systems AG

        = 0x0CF4
          SOLUX PTY LTD

        = 0x0CF3
          Radio Sound

        = 0x0CF2
          BestSens AG

        = 0x0CF1
          Midmark

        = 0x0CF0
          THOTAKA TEKHNOLOGIES INDIA PRIVATE LIMITED

        = 0x0CEF
          POGS B.V.

        = 0x0CEE
          MadgeTech, Inc

        = 0x0CED
          CV. NURI TEKNIK

        = 0x0CEC
          Pacific Coast Fishery Services (2003) Inc.

        = 0x0CEB
          Shenzhen Tingting Technology Co. LTD

        = 0x0CEA
          HAYWARD INDUSTRIES, INC.

        = 0x0CE9
          PEAG, LLC dba JLab Audio

        = 0x0CE8
          Dongguan Yougo Electronics Co.,Ltd.

        = 0x0CE7
          TAG HEUER SA

        = 0x0CE6
          McWong International, Inc.

        = 0x0CE5
          Amina Distribution AS

        = 0x0CE4
          Off-Highway Powertrain Services Germany GmbH

        = 0x0CE3
          Taiwan Fuhsing

        = 0x0CE2
          CORVENT MEDICAL, INC.

        = 0x0CE1
          Regal Beloit America, Inc.

        = 0x0CE0
          VODALOGIC PTY LTD

        = 0x0CDF
          SHENZHEN CHENYUN ELECTRONICS  CO., LTD

        = 0x0CDE
          RESPONSE TECHNOLOGIES, LTD.

        = 0x0CDD
          Alif Semiconductor, Inc.

        = 0x0CDC
          Ypsomed AG

        = 0x0CDB
          Circus World Displays Limited

        = 0x0CDA
          Wolf Steel ltd

        = 0x0CD9
          Minami acoustics Limited

        = 0x0CD8
          SIA Mesh Group

        = 0x0CD7
          Maztech Industries, LLC

        = 0x0CD6
          HHO (Hangzhou) Digital Technology Co., Ltd.

        = 0x0CD5
          Numa Products, LLC

        = 0x0CD4
          Shenzhen Zhiduotun IoT Technology Co., Ltd

        = 0x0CD3
          TechSwipe

        = 0x0CD2
          EQOM SSC B.V.

        = 0x0CD1
          Imagine Marketing Limited

        = 0x0CD0
          MooreSilicon Semiconductor Technology (Shanghai) Co., LTD.

        = 0x0CCF
          Shenzhen CESI Information Technology Co., Ltd.

        = 0x0CCE
          SENOSPACE LLC

        = 0x0CCD
          YanFeng Visteon(Chongqing) Automotive Electronic Co.,Ltd

        = 0x0CCC
          Kord Defence Pty Ltd

        = 0x0CCB
          NOTHING TECHNOLOGY LIMITED

        = 0x0CCA
          Cyclops Marine Ltd

        = 0x0CC9
          Innocent Technology Co., Ltd.

        = 0x0CC8
          TrikThom

        = 0x0CC7
          SB C&S Corp.

        = 0x0CC6
          Serial Technology Corporation

        = 0x0CC5
          Open Road Solutions, Inc.

        = 0x0CC4
          ABUS August Bremicker Soehne Kommanditgesellschaft

        = 0x0CC3
          HMD Global Oy

        = 0x0CC2
          Anker Innovations Limited

        = 0x0CC1
          CLEIO Inc.

        = 0x0CC0
          Garnet Instruments Ltd.

        = 0x0CBF
          Forward Thinking Systems LLC.

        = 0x0CBD
          Pricer AB

        = 0x0CBC
          TROX GmbH

        = 0x0CBB
          Emlid Tech Kft.

        = 0x0CBA
          Ameso Tech (OPC) Private Limited

        = 0x0CB9
          seca GmbH & Co. KG

        = 0x0CB8
          Shanghai Proxy Network Technology Co., Ltd.

        = 0x0CB7
          Cucumber Lighting Controls Limited

        = 0x0CB6
          THE EELECTRIC MACARON LLC

        = 0x0CB5
          Racketry, d. o. o.

        = 0x0CB4
          Eberspaecher Climate Control Systems GmbH

        = 0x0CB3
          janova GmbH

        = 0x0CB2
          SHINKAWA Sensor Technology, Inc.

        = 0x0CB1
          RF Creations

        = 0x0CB0
          SwipeSense, Inc.

        = 0x0CAF
          NEURINNOV

        = 0x0CAE
          Evident Corporation

        = 0x0CAD
          Shenzhen Openhearing Tech CO., LTD .

        = 0x0CAC
          Shenzhen Shokz Co.,Ltd.

        = 0x0CAB
          HERUTU ELECTRONICS CORPORATION

        = 0x0CAA
          Shenzhen Poseidon Network Technology Co., Ltd

        = 0x0CA9
          Mievo Technologies Private Limited

        = 0x0CA8
          Sonas, Inc.

        = 0x0CA7
          Verve InfoTec Pty Ltd

        = 0x0CA6
          Megger Ltd

        = 0x0CA5
          Princess Cruise Lines, Ltd.

        = 0x0CA4
          MITSUBISHI ELECTRIC LIGHTING CO, LTD

        = 0x0CA3
          MAQUET GmbH

        = 0x0CA2
          XSENSE LTD

        = 0x0CA1
          YAMAHA MOTOR CO.,LTD.

        = 0x0CA0
          BIGBEN

        = 0x0C9F
          Dragonfly Energy Corp.

        = 0x0C9E
          ECCEL CORPORATION SAS

        = 0x0C9D
          Ribbiot, INC.

        = 0x0C9C
          Sunstone-RTLS Ipari Szolgaltato Korlatolt Felelossegu Tarsasag

        = 0x0C9B
          NTT sonority, Inc.

        = 0x0C9A
          ALF Inc.

        = 0x0C99
          Vire Health Oy

        = 0x0C98
          MiX Telematics International (PTY) LTD

        = 0x0C97
          Deako

        = 0x0C96
          H+B Hightech GmbH

        = 0x0C95
          Gemstone Lights Canada Ltd.

        = 0x0C94
          Baxter Healthcare Corporation

        = 0x0C93
          Movesense Oy

        = 0x0C92
          KessebÃ¶hmer Ergonomietechnik GmbH

        = 0x0C91
          Yashu Systems

        = 0x0C90
          WESCO AG

        = 0x0C8F
          Radar Automobile Sales(Shandong)Co.,Ltd.

        = 0x0C8E
          Technocon Engineering Ltd.

        = 0x0C8D
          tonies GmbH

        = 0x0C8C
          T-Mobile USA

        = 0x0C8B
          Heavys Inc

        = 0x0C8A
          ARTISTIC&CO.GLOBAL Ltd.

        = 0x0C89
          AGZZX OPTOELECTRONICS TECHNOLOGY CO., LTD

        = 0x0C88
          Nextivity Inc.

        = 0x0C87
          Weltek Technologies Company Limited

        = 0x0C86
          Qingdao Eastsoft Communication Technology Co.,Ltd

        = 0x0C85
          Amlogic, Inc.

        = 0x0C84
          MAXON INDUSTRIES, INC.

        = 0x0C83
          Watchdog Systems LLC

        = 0x0C82
          NACON

        = 0x0C81
          Carrier Corporation

        = 0x0C80
          CARDIOID - TECHNOLOGIES, LDA

        = 0x0C7F
          Rochester Sensors, LLC

        = 0x0C7E
          BOOMING OF THINGS

        = 0x0C7D
          3ALogics, Inc.

        = 0x0C7C
          Mopeka Products LLC

        = 0x0C7B
          PT SADAMAYA GRAHA TEKNOLOGI

        = 0x0C7A
          Triductor Technology (Suzhou), Inc.

        = 0x0C79
          Zhuhai Smartlink Technology Co., Ltd

        = 0x0C78
          CHARGTRON IOT PRIVATE LIMITED

        = 0x0C77
          TEAC Corporation

        = 0x0C76
          Shenzhen Gwell Times Technology Co. , Ltd

        = 0x0C75
          Embedded Engineering Solutions LLC

        = 0x0C74
          yupiteru

        = 0x0C73
          Truma GerÃ¤tetechnik GmbH & Co. KG

        = 0x0C72
          StreetCar ORV, LLC

        = 0x0C71
          BitGreen Technolabz (OPC) Private Limited

        = 0x0C70
          SCARAB SOLUTIONS LTD

        = 0x0C6F
          Parakey AB

        = 0x0C6E
          Sensa LLC

        = 0x0C6D
          Fidure Corp.

        = 0x0C6C
          SNIFF LOGIC LTD

        = 0x0C6B
          GILSON SAS

        = 0x0C6A
          CONSORCIO TRUST CONTROL - NETTEL

        = 0x0C69
          BLITZ electric motors. LTD

        = 0x0C68
          Emerja Corporation

        = 0x0C67
          TRACKTING S.R.L.

        = 0x0C66
          DEN Smart Home B.V.

        = 0x0C65
          WAKO CO,.LTD

        = 0x0C64
          dormakaba Holding AG

        = 0x0C63
          phg Peter Hengstler GmbH + Co. KG

        = 0x0C62
          Phiaton Corporation

        = 0x0C61
          NNOXX, Inc

        = 0x0C60
          KEBA Energy Automation GmbH

        = 0x0C5F
          Nanjing Linkpower Microelectronics Co.,Ltd

        = 0x0C5E
          BlueID GmbH

        = 0x0C5D
          StepUp Solutions ApS

        = 0x0C5C
          MGM WIRELESSS HOLDINGS PTY LTD

        = 0x0C5B
          Alban Giacomo S.P.A.

        = 0x0C5A
          Lockswitch Sdn Bhd

        = 0x0C59
          CYBERDYNE Inc.

        = 0x0C58
          Hykso Inc.

        = 0x0C57
          UNEEG medical A/S

        = 0x0C56
          Rheem Sales Company, Inc.

        = 0x0C55
          Zintouch B.V.

        = 0x0C54
          HiViz Lighting, Inc.

        = 0x0C53
          Taco, Inc.

        = 0x0C52
          ESCEA LIMITED

        = 0x0C51
          INNOVA S.R.L.

        = 0x0C50
          Imostar Technologies Inc.

        = 0x0C4F
          SharkNinja Operating LLC

        = 0x0C4E
          Tactile Engineering, Inc.

        = 0x0C4D
          Seekwave Technology Co.,ltd.

        = 0x0C4C
          Orpyx Medical Technologies Inc.

        = 0x0C4B
          ADTRAN, Inc.

        = 0x0C4A
          atSpiro ApS

        = 0x0C49
          twopounds gmbh

        = 0x0C48
          VALEO MANAGEMENT SERVICES

        = 0x0C47
          Epsilon Electronics,lnc

        = 0x0C46
          Granwin IoT Technology (Guangzhou) Co.,Ltd

        = 0x0C45
          Brose Verwaltung SE, Bamberg

        = 0x0C44
          ONCELABS LLC

        = 0x0C43
          Berlinger & Co. AG

        = 0x0C42
          Heath Consultants Inc.

        = 0x0C41
          Control Solutions LLC

        = 0x0C40
          HORIBA, Ltd.

        = 0x0C3F
          Stinger Equipment, Inc.

        = 0x0C3E
          BELLDESIGN Inc.

        = 0x0C3D
          Wrmth Corp.

        = 0x0C3C
          Classified Cycling

        = 0x0C3B
          ORB Innovations Ltd

        = 0x0C3A
          Equinosis, LLC

        = 0x0C39
          TIGER CORPORATION

        = 0x0C38
          Noritz Corporation.

        = 0x0C37
          SignalQuest, LLC

        = 0x0C36
          Cosmicnode BV

        = 0x0C35
          Thermokon-Sensortechnik GmbH

        = 0x0C34
          BYD Company Limited

        = 0x0C33
          Exeger Operations AB

        = 0x0C32
          Xian Yisuobao Electronic Technology Co., Ltd.

        = 0x0C31
          KINDOO LLP

        = 0x0C30
          McIntosh Group Inc

        = 0x0C2F
          BEEHERO, INC.

        = 0x0C2E
          Easee AS

        = 0x0C2D
          OTF Product Sourcing, LLC

        = 0x0C2C
          Zeku Technology (Shanghai) Corp., Ltd.

        = 0x0C2B
          GigaDevice Semiconductor Inc.

        = 0x0C2A
          Caresix Inc.

        = 0x0C29
          DENSO AIRCOOL CORPORATION

        = 0x0C28
          Embecta Corp.

        = 0x0C27
          Pal Electronics

        = 0x0C26
          Performance Electronics, Ltd.

        = 0x0C25
          JURA Elektroapparate AG

        = 0x0C24
          SMARTD TECHNOLOGIES INC.

        = 0x0C23
          KEYTEC,Inc.

        = 0x0C22
          Glamo Inc.

        = 0x0C21
          Foshan Viomi Electrical Technology Co., Ltd

        = 0x0C20
          COMELIT GROUP S.P.A.

        = 0x0C1F
          LVI Co.

        = 0x0C1E
          EC sense co., Ltd

        = 0x0C1D
          OFF Line Japan Co., Ltd.

        = 0x0C1C
          GEMU

        = 0x0C1B
          Rockchip Electronics Co., Ltd.

        = 0x0C1A
          Catapult Group International Ltd

        = 0x0C19
          Arlo Technologies, Inc.

        = 0x0C18
          CORROHM

        = 0x0C17
          SomnoMed Limited

        = 0x0C16
          TYKEE PTY. LTD.

        = 0x0C15
          Geva Sol B.V.

        = 0x0C14
          Fasetto, Inc.

        = 0x0C13
          Scandinavian Health Limited

        = 0x0C12
          IoSA

        = 0x0C11
          Gordon Murray Design Limited

        = 0x0C10
          Cosmed s.r.l.

        = 0x0C0F
          AETERLINK

        = 0x0C0E
          ALEX DENKO CO.,LTD.

        = 0x0C0D
          Mereltron bv

        = 0x0C0C
          Mendeltron, Inc.

        = 0x0C0B
          aconno GmbH

        = 0x0C0A
          Automated Pet Care Products, LLC

        = 0x0C09
          Senic Inc.

        = 0x0C08
          limited liability company "Red"

        = 0x0C07
          CONSTRUKTS, INC.

        = 0x0C06
          LED Smart Inc.

        = 0x0C05
          Montage Connect, Inc.

        = 0x0C04
          Happy Health, Inc.

        = 0x0C03
          Puff Corp

        = 0x0C02
          Loomanet, Inc.

        = 0x0C01
          NEOWRK SISTEMAS INTELIGENTES S.A.

        = 0x0C00
          MQA Limited

        = 0x0BFF
          Ratio Electric BV

        = 0x0BFE
          Media-Cartec GmbH

        = 0x0BFD
          EsmÃ© Solutions

        = 0x0BFC
          T+A elektroakustik GmbH & Co.KG

        = 0x0BFB
          Dodam Enersys Co., Ltd

        = 0x0BFA
          CleanBands Systems Ltd.

        = 0x0BF9
          Alio, Inc

        = 0x0BF8
          Innovacionnye Resheniya

        = 0x0BF7
          Wacker Neuson SE

        = 0x0BF6
          greenTEG AG

        = 0x0BF5
          T5 tek, Inc.

        = 0x0BF4
          ER Lab LLC

        = 0x0BF3
          PONE BIOMETRICS AS

        = 0x0BF2
          Angel Medical Systems, Inc.

        = 0x0BF1
          Site IQ LLC

        = 0x0BF0
          KIDO SPORTS CO., LTD.

        = 0x0BEF
          Safetytest GmbH

        = 0x0BEE
          LINKSYS USA, INC.

        = 0x0BED
          CORAL-TAIYI Co. Ltd.

        = 0x0BEC
          Miracle-Ear, Inc.

        = 0x0BEB
          Luna Health, Inc.

        = 0x0BEA
          Twenty Five Seven, prodaja in storitve, d.o.o.

        = 0x0BE9
          Shindengen Electric Manufacturing Co., Ltd.

        = 0x0BE8
          Sensormate AG

        = 0x0BE7
          Fresnel Technologies, Inc.

        = 0x0BE6
          Puratap Pty Ltd

        = 0x0BE5
          ZWILLING J.A. Henckels Aktiengesellschaft

        = 0x0BE4
          Deepfield Connect GmbH

        = 0x0BE3
          Comtel Systems Ltd.

        = 0x0BE2
          OTC engineering

        = 0x0BE1
          Back40 Precision

        = 0x0BE0
          Koizumi Lighting Technology corp.

        = 0x0BDF
          WINKEY ENTERPRISE (HONG KONG) LIMITED

        = 0x0BDE
          Yale

        = 0x0BDD
          Coroflo Limited

        = 0x0BDC
          Ledworks S.r.l.

        = 0x0BDB
          CHAR-BROIL, LLC

        = 0x0BDA
          Aardex Ltd.

        = 0x0BD9
          Elics Basis Ltd.

        = 0x0BD8
          PURA SCENTS, INC.

        = 0x0BD7
          VINFAST TRADING AND PRODUCTION JOINT STOCK COMPANY

        = 0x0BD6
          Shenzhen Injoinic Technology Co., Ltd.

        = 0x0BD5
          Super B Lithium Power B.V.

        = 0x0BD4
          ndd Medizintechnik AG

        = 0x0BD3
          Procon Analytics, LLC

        = 0x0BD2
          IDEC

        = 0x0BD1
          Hubei Yuan Times Technology Co., Ltd.

        = 0x0BD0
          Durag GmbH

        = 0x0BCF
          LL Tec Group LLC

        = 0x0BCE
          Neurosity, Inc.

        = 0x0BCD
          Amiko srl

        = 0x0BCC
          Sylvac sa

        = 0x0BCB
          Divesoft s.r.o.

        = 0x0BCA
          Perimeter Technologies, Inc.

        = 0x0BC9
          Neuvatek Inc.

        = 0x0BC8
          OTF Distribution, LLC

        = 0x0BC7
          Signtle Inc.

        = 0x0BC6
          TCL COMMUNICATION EQUIPMENT CO.,LTD.

        = 0x0BC5
          Aperia Technologies, Inc.

        = 0x0BC4
          TECHTICS ENGINEERING B.V.

        = 0x0BC3
          MCOT INC.

        = 0x0BC2
          EntWick Co.

        = 0x0BC1
          Miele & Cie. KG

        = 0x0BC0
          READY FOR SKY LLP

        = 0x0BBF
          HIMSA II K/S

        = 0x0BBE
          SAAB Aktiebolag

        = 0x0BBD
          ETHEORY PTY LTD

        = 0x0BBC
          T2REALITY SOLUTIONS PRIVATE LIMITED

        = 0x0BBB
          SWISSINNO SOLUTIONS AG

        = 0x0BBA
          Huso, INC

        = 0x0BB9
          SaluStim Group Oy

        = 0x0BB8
          INNOVAG PTY. LTD.

        = 0x0BB7
          IONA Tech LLC

        = 0x0BB6
          Build With Robots Inc.

        = 0x0BB5
          Xirgo Technologies, LLC

        = 0x0BB4
          New Cosmos USA, Inc.

        = 0x0BB3
          Flender GmbH

        = 0x0BB2
          Fjorden Electra AS

        = 0x0BB1
          Beijing ranxin intelligence technology Co.,LTD

        = 0x0BB0
          Ecolab Inc.

        = 0x0BAF
          NITTO KOGYO CORPORATION

        = 0x0BAE
          Soma Labs LLC

        = 0x0BAD
          Roambotics, Inc.

        = 0x0BAC
          Machfu Inc.

        = 0x0BAB
          Grandex International Corporation

        = 0x0BAA
          Infinitegra, Inc.

        = 0x0BA9
          Allterco Robotics ltd

        = 0x0BA8
          GLOWFORGE INC.

        = 0x0BA7
          hearX Group (Pty) Ltd

        = 0x0BA6
          Nissan Motor Co., Ltd.

        = 0x0BA5
          SONICOS ENTERPRISES, LLC

        = 0x0BA4
          Vervent Audio Group

        = 0x0BA3
          Sonova Consumer Hearing GmbH

        = 0x0BA2
          TireCheck GmbH

        = 0x0BA1
          Bunn-O-Matic Corporation

        = 0x0BA0
          Data Sciences International

        = 0x0B9F
          Group Lotus Limited

        = 0x0B9E
          Audio Partnership Plc

        = 0x0B9D
          Sensoria Holdings LTD

        = 0x0B9C
          Komatsu Ltd.

        = 0x0B9B
          GISMAN

        = 0x0B9A
          Beijing Wisepool Infinite Intelligence Technology Co.,Ltd

        = 0x0B99
          The Goodyear Tire & Rubber Company

        = 0x0B98
          Gymstory B.V.

        = 0x0B97
          SILVER TREE LABS, INC.

        = 0x0B96
          Telecom Design

        = 0x0B95
          Netwake GmbH

        = 0x0B94
          Dreem SAS

        = 0x0B93
          Hangzhou BroadLink Technology Co., Ltd.

        = 0x0B92
          Citisend Solutions, SL

        = 0x0B91
          Alfen ICU B.V.

        = 0x0B90
          Ineos Automotive Limited

        = 0x0B8F
          Senscomm Semiconductor Co., Ltd.

        = 0x0B8E
          Gentle Energy Corp.

        = 0x0B8D
          Pertech Industries Inc

        = 0x0B8C
          MOTREX

        = 0x0B8B
          American Technology Components, Incorporated

        = 0x0B8A
          Seiko Instruments Inc.

        = 0x0B89
          Rotronic AG

        = 0x0B88
          Muguang (Guangdong) Intelligent Lighting Technology Co., Ltd

        = 0x0B87
          Ampetronic Ltd

        = 0x0B86
          Trek Bicycle

        = 0x0B85
          VIMANA TECH PTY LTD

        = 0x0B84
          Presidio Medical, Inc.

        = 0x0B83
          Taiga Motors Inc.

        = 0x0B82
          Mammut Sports Group AG

        = 0x0B81
          SCM Group

        = 0x0B80
          AXELIFE

        = 0x0B7F
          ICU tech GmbH

        = 0x0B7E
          Offcode Oy

        = 0x0B7D
          FoundersLane GmbH

        = 0x0B7C
          Scangrip A/S

        = 0x0B7B
          Hardcoder Oy

        = 0x0B7A
          Shenzhen KTC Technology Co.,Ltd.

        = 0x0B79
          Sankyo Air Tech Co.,Ltd.

        = 0x0B78
          FIELD DESIGN INC.

        = 0x0B77
          Aixlink(Chengdu) Co., Ltd.

        = 0x0B76
          MAX-co., ltd

        = 0x0B75
          Triple W Japan Inc.

        = 0x0B74
          BQN

        = 0x0B73
          HARADA INDUSTRY CO., LTD.

        = 0x0B72
          Geeknet, Inc.

        = 0x0B71
          lilbit ODM AS

        = 0x0B70
          JDRF Electromag Engineering Inc

        = 0x0B6F
          Shenzhen Malide Technology Co.,Ltd

        = 0x0B6E
          React Mobile

        = 0x0B6D
          SOLUM CO., LTD

        = 0x0B6C
          Sensitech, Inc.

        = 0x0B6B
          Samsara Networks, Inc

        = 0x0B6A
          Dymo

        = 0x0B69
          Addaday

        = 0x0B68
          Quha oy

        = 0x0B67
          CleanSpace Technology Pty Ltd

        = 0x0B66
          MITSUBISHI ELECTRIC AUTOMATION (THAILAND) COMPANY LIMITED

        = 0x0B65
          The Apache Software Foundation

        = 0x0B64
          NingBo klite Electric Manufacture Co.,LTD

        = 0x0B63
          Innolux Corporation

        = 0x0B62
          NOVEA ENERGIES

        = 0x0B61
          Sentek Pty Ltd

        = 0x0B60
          RATOC Systems, Inc.

        = 0x0B5F
          Rivieh, Inc.

        = 0x0B5E
          CELLCONTROL, INC.

        = 0x0B5D
          Fujian Newland Auto-ID Tech. Co., Ltd.

        = 0x0B5C
          Exponential Power, Inc.

        = 0x0B5B
          Shenzhen ImagineVision Technology Limited

        = 0x0B5A
          H.P. Shelby Manufacturing, LLC.

        = 0x0B59
          Versa Group B.V.

        = 0x0B58
          TOKAI-DENSHI INC

        = 0x0B57
          CONVERTRONIX TECHNOLOGIES AND SERVICES LLP

        = 0x0B56
          BORA - Vertriebs GmbH & Co KG

        = 0x0B55
          H G M Automotive Electronics, Inc.

        = 0x0B54
          Emotion Fitness GmbH & Co. KG

        = 0x0B53
          SHENZHEN KAADAS INTELLIGENT TECHNOLOGY CO.,Ltd

        = 0x0B52
          ZIIP Inc

        = 0x0B51
          FUN FACTORY GmbH

        = 0x0B50
          Mesh Systems LLC

        = 0x0B4F
          Breezi.io, Inc.

        = 0x0B4E
          ICP Systems B.V.

        = 0x0B4D
          Adam Hall GmbH

        = 0x0B4C
          BiosBob.Biz

        = 0x0B4B
          EMS Integrators, LLC

        = 0x0B4A
          Nomono AS

        = 0x0B49
          SkyHawke Technologies

        = 0x0B48
          NIO USA, Inc.

        = 0x0B47
          Gentex Corporation

        = 0x0B46
          Bird Rides, Inc.

        = 0x0B45
          Electronic Sensors, Inc.

        = 0x0B44
          nFore Technology Co., Ltd.

        = 0x0B43
          INCITAT ENVIRONNEMENT

        = 0x0B42
          TSI

        = 0x0B41
          Sentrax GmbH

        = 0x0B40
          Havells India Limited

        = 0x0B3F
          MindRhythm, Inc.

        = 0x0B3E
          ISEO Serrature S.p.a.

        = 0x0B3D
          REALTIMEID AS

        = 0x0B3C
          Dodge Industrial, Inc.

        = 0x0B3B
          AIC semiconductor (Shanghai) Co., Ltd.

        = 0x0B3A
          Impact Biosystems, Inc.

        = 0x0B39
          Red 100 Lighting Co., ltd.

        = 0x0B38
          WISYCOM S.R.L.

        = 0x0B37
          Omnivoltaic Energy Solutions Limited Company

        = 0x0B36
          SINTEF

        = 0x0B35
          BH SENS

        = 0x0B34
          CONZUMEX INDUSTRIES PRIVATE LIMITED

        = 0x0B33
          ARMATURA LLC

        = 0x0B32
          Hala Systems, Inc.

        = 0x0B31
          Silver Wolf Vehicles Inc.

        = 0x0B30
          ART SPA

        = 0x0B2F
          Duke Manufacturing Co

        = 0x0B2E
          MOCA System Inc.

        = 0x0B2D
          REDARC ELECTRONICS PTY LTD

        = 0x0B2C
          ILLUMAGEAR, Inc.

        = 0x0B2B
          MAINBOT

        = 0x0B2A
          ACL Airshop B.V.

        = 0x0B29
          Tech-Venom Entertainment Private Limited

        = 0x0B28
          CHACON

        = 0x0B27
          Lumi United Technology Co., Ltd

        = 0x0B26
          Baracoda Daily Healthtech.

        = 0x0B25
          NIBROTECH LTD

        = 0x0B24
          BeiJing ZiJie TiaoDong KeJi Co.,Ltd.

        = 0x0B23
          iRhythm Technologies, Inc.

        = 0x0B22
          Hygiene IQ, LLC.

        = 0x0B21
          ams AG

        = 0x0B20
          TKH Security B.V.

        = 0x0B1F
          Beijing ESWIN Computing Technology Co., Ltd.

        = 0x0B1E
          PB INC.

        = 0x0B1D
          Accelerated Systems

        = 0x0B1C
          Nanoleq AG

        = 0x0B1B
          Enerpac Tool Group Corp.

        = 0x0B1A
          Roca Sanitario, S.A.

        = 0x0B19
          WBS PROJECT H PTY LTD

        = 0x0B18
          DECATHLON SE

        = 0x0B17
          SIG SAUER, INC.

        = 0x0B16
          Guard RFID Solutions Inc.

        = 0x0B15
          NAOS JAPAN K.K.

        = 0x0B14
          Olumee

        = 0x0B13
          IOTOOLS

        = 0x0B12
          ToughBuilt Industries LLC

        = 0x0B11
          ThermoWorks, Inc.

        = 0x0B10
          Alfa Laval Corporate AB

        = 0x0B0F
          B.E.A. S.A.

        = 0x0B0E
          Honda Lock Mfg. Co.,Ltd.

        = 0x0B0D
          SANYO DENKO Co.,Ltd.

        = 0x0B0C
          BluPeak

        = 0x0B0B
          Sanistaal A/S

        = 0x0B0A
          Belun Technology Company Limited

        = 0x0B09
          soonisys

        = 0x0B08
          Shenzhen Qianfenyi Intelligent Technology Co., LTD

        = 0x0B07
          Workaround Gmbh

        = 0x0B06
          FAZUA GmbH

        = 0x0B05
          Marquardt GmbH

        = 0x0B04
          I-PERCUT

        = 0x0B03
          Precision Triathlon Systems Limited

        = 0x0B02
          IORA Technology Development Ltd. Sti.

        = 0x0B01
          RESIDEO TECHNOLOGIES, INC.

        = 0x0B00
          Flaircomm Microelectronics Inc.

        = 0x0AFF
          FUSEAWARE LIMITED

        = 0x0AFE
          Earda Technologies Co.,Ltd

        = 0x0AFD
          Weber Sensors, LLC

        = 0x0AFC
          Cerebrum Sensor Technologies Inc.

        = 0x0AFB
          SMT ELEKTRONIK GmbH

        = 0x0AFA
          Chengdu Ambit Technology Co., Ltd.

        = 0x0AF9
          Unisto AG

        = 0x0AF8
          First Design System Inc.

        = 0x0AF7
          Irdeto

        = 0x0AF6
          AMETEK, Inc.

        = 0x0AF5
          Unitech Electronic Inc.

        = 0x0AF4
          Radioworks Microelectronics PTY LTD

        = 0x0AF3
          701x Inc.

        = 0x0AF2
          Shanghai All Link Microelectronics Co.,Ltd

        = 0x0AF1
          CRADERS,CO.,LTD

        = 0x0AF0
          Leupold & Stevens, Inc.

        = 0x0AEF
          GLP German Light Products GmbH

        = 0x0AEE
          Velentium, LLC

        = 0x0AED
          Saxonar GmbH

        = 0x0AEC
          FUTEK ADVANCED SENSOR TECHNOLOGY, INC

        = 0x0AEB
          Square, Inc.

        = 0x0AEA
          Borda Technology

        = 0x0AE9
          FLIR Systems AB

        = 0x0AE8
          LEVEL, s.r.o.

        = 0x0AE7
          Sunplus Technology Co., Ltd.

        = 0x0AE6
          Hexology

        = 0x0AE5
          unu GmbH

        = 0x0AE4
          DALI Alliance

        = 0x0AE3
          GlobalMed

        = 0x0AE2
          IMATRIX SYSTEMS, INC.

        = 0x0AE1
          ChengDu ForThink Technology Co., Ltd.

        = 0x0AE0
          Viceroy Devices Corporation

        = 0x0ADF
          Douglas Dynamics L.L.C.

        = 0x0ADE
          Vocera Communications, Inc.

        = 0x0ADD
          Boss Audio

        = 0x0ADC
          Duravit AG

        = 0x0ADB
          Reelables, Inc.

        = 0x0ADA
          Codefabrik GmbH

        = 0x0AD9
          Shenzhen Aimore. Co.,Ltd

        = 0x0AD8
          Franz Kaldewei GmbH&Co KG

        = 0x0AD7
          AL-KO Geraete GmbH

        = 0x0AD6
          nymea GmbH

        = 0x0AD5
          Streamit B.V.

        = 0x0AD4
          Zhuhai Pantum Electronisc Co., Ltd

        = 0x0AD3
          SSV Software Systems GmbH

        = 0x0AD2
          Lautsprecher Teufel GmbH

        = 0x0AD1
          EAGLE KINGDOM TECHNOLOGIES LIMITED

        = 0x0AD0
          Nordic Strong ApS

        = 0x0ACF
          CACI Technologies

        = 0x0ACE
          KOBATA GAUGE MFG. CO., LTD.

        = 0x0ACD
          Visuallex Sport International Limited

        = 0x0ACC
          Nuvoton

        = 0x0ACB
          ise Individuelle Software und Elektronik GmbH

        = 0x0ACA
          Shenzhen CoolKit Technology Co., Ltd

        = 0x0AC9
          Swedlock AB

        = 0x0AC8
          Keepin Co., Ltd.

        = 0x0AC7
          Chengdu Aich Technology Co.,Ltd

        = 0x0AC6
          Barnes Group Inc.

        = 0x0AC5
          Flexoptix GmbH

        = 0x0AC4
          CODIUM

        = 0x0AC3
          Kenzen, Inc.

        = 0x0AC2
          RealMega Microelectronics technology (Shanghai) Co. Ltd.

        = 0x0AC1
          Shenzhen Jingxun Technology Co., Ltd.

        = 0x0AC0
          Omni-ID USA, INC.

        = 0x0ABF
          PAUL HARTMANN AG

        = 0x0ABE
          Robkoo Information & Technologies Co., Ltd.

        = 0x0ABD
          Inventas AS

        = 0x0ABC
          KCCS Mobile Engineering Co., Ltd.

        = 0x0ABB
          R-DAS, s.r.o.

        = 0x0ABA
          Open Bionics Ltd.

        = 0x0AB9
          STL

        = 0x0AB8
          Sens.ai Incorporated

        = 0x0AB7
          LogTag North America Inc.

        = 0x0AB6
          Xenter, Inc.

        = 0x0AB5
          Elstat Electronics Ltd.

        = 0x0AB4
          Ellenby Technologies, Inc.

        = 0x0AB3
          INNER RANGE PTY. LTD.

        = 0x0AB2
          TouchTronics, Inc.

        = 0x0AB1
          InVue Security Products Inc

        = 0x0AB0
          Visiontronic s.r.o.

        = 0x0AAF
          AIAIAI ApS

        = 0x0AAE
          PS Engineering, Inc.

        = 0x0AAD
          Adevo Consulting AB

        = 0x0AAC
          OSM HK Limited

        = 0x0AAB
          Anhui Listenai Co

        = 0x0AAA
          Computime International Ltd

        = 0x0AA9
          Spintly, Inc.

        = 0x0AA8
          Zencontrol Pty Ltd

        = 0x0AA7
          Urbanista AB

        = 0x0AA6
          Realityworks, inc.

        = 0x0AA5
          Shenzhen Uascent Technology Co., Ltd

        = 0x0AA4
          FAZEPRO LLC

        = 0x0AA3
          DIC Corporation

        = 0x0AA2
          Care Bloom, LLC

        = 0x0AA1
          LINCOGN TECHNOLOGY CO. LIMITED

        = 0x0AA0
          Loy Tec electronics GmbH

        = 0x0A9F
          ista International GmbH

        = 0x0A9E
          LifePlus, Inc.

        = 0x0A9D
          Canon Finetech Nisca Inc.

        = 0x0A9C
          name: "Xian Fengyu Information Technology Co., Ltd."

        = 0x0A9B
          Eello LLC

        = 0x0A9A
          TEMKIN ASSOCIATES, LLC

        = 0x0A99
          Shanghai high-flying electronics technology Co.,Ltd

        = 0x0A98
          Foil, Inc.

        = 0x0A97
          SensTek

        = 0x0A96
          Lightricity Ltd

        = 0x0A95
          Pamex Inc.

        = 0x0A94
          OOBIK Inc.

        = 0x0A93
          GiPStech S.r.l.

        = 0x0A92
          Carestream Dental LLC

        = 0x0A91
          Monarch International Inc.

        = 0x0A90
          Shenzhen Grandsun Electronic Co.,Ltd.

        = 0x0A8F
          TOTO LTD.

        = 0x0A8E
          Perfect Company

        = 0x0A8D
          JCM TECHNOLOGIES S.A.

        = 0x0A8C
          DelpSys, s.r.o.

        = 0x0A8B
          SANlight GmbH

        = 0x0A8A
          HAINBUCH GMBH SPANNENDE TECHNIK

        = 0x0A89
          SES-Imagotag

        = 0x0A88
          PSA Peugeot Citroen

        = 0x0A87
          Shanghai Smart System Technology Co., Ltd

        = 0x0A86
          ALIZENT International

        = 0x0A85
          Snowball Technology Co., Ltd.

        = 0x0A84
          Greennote Inc,

        = 0x0A83
          Rivata, Inc.

        = 0x0A82
          Corsair

        = 0x0A81
          Universal Biosensors Pty Ltd

        = 0x0A80
          Cleer Limited

        = 0x0A7F
          Intuity Medical

        = 0x0A7E
          KEBA Handover Automation GmbH

        = 0x0A7D
          Freedman Electronics Pty Ltd

        = 0x0A7C
          WAFERLOCK

        = 0x0A7B
          UniqAir Oy

        = 0x0A7A
          Emlid Limited

        = 0x0A79
          Webasto SE

        = 0x0A78
          Shenzhen Sunricher Technology Limited

        = 0x0A77
          AXTRO PTE. LTD.

        = 0x0A76
          Synaptics Incorporated

        = 0x0A75
          Delta Cycle Corporation

        = 0x0A74
          MICROSON S.A.

        = 0x0A73
          Innohome Oy

        = 0x0A72
          Jumo GmbH & Co. KG

        = 0x0A71
          Senquip Pty Ltd

        = 0x0A70
          Ooma

        = 0x0A6F
          Warner Bros.

        = 0x0A6E
          Pac Sane Limited

        = 0x0A6D
          KUUKANJYOKIN Co.,Ltd.

        = 0x0A6C
          Pokkels

        = 0x0A6B
          Olympic Ophthalmics, Inc.

        = 0x0A6A
          Scribble Design Inc.

        = 0x0A69
          HAPPIEST BABY, INC.

        = 0x0A68
          Focus Ingenieria SRL

        = 0x0A67
          Beijing SuperHexa Century Technology CO. Ltd

        = 0x0A66
          JUSTMORPH PTE. LTD.

        = 0x0A65
          Lytx, INC.

        = 0x0A64
          Geopal system A/S

        = 0x0A63
          Gremsy JSC

        = 0x0A62
          MOKO TECHNOLOGY Ltd

        = 0x0A61
          Smart Parks B.V.

        = 0x0A60
          DATANG SEMICONDUCTOR TECHNOLOGY CO.,LTD

        = 0x0A5F
          stryker

        = 0x0A5E
          LaceClips llc

        = 0x0A5D
          MG Energy Systems B.V.

        = 0x0A5C
          Innovative Design Labs Inc.

        = 0x0A5B
          LEGIC Identsystems AG

        = 0x0A5A
          Sontheim Industrie Elektronik GmbH

        = 0x0A59
          TourBuilt, LLC

        = 0x0A58
          Indigo Diabetes

        = 0x0A57
          Meizhou Guo Wei Electronics Co., Ltd

        = 0x0A56
          ambie

        = 0x0A55
          Inugo Systems Limited

        = 0x0A54
          SQL Technologies Corp.

        = 0x0A53
          KKM COMPANY LIMITED

        = 0x0A52
          Follow Sense Europe B.V.

        = 0x0A51
          CSIRO

        = 0x0A50
          Nextscape Inc.

        = 0x0A4F
          VANMOOF Global Holding B.V.

        = 0x0A4E
          Toytec Corporation

        = 0x0A4D
          Lockn Technologies Private Limited

        = 0x0A4C
          SiFli Technologies (shanghai) Inc.

        = 0x0A4B
          MistyWest Energy and Transport Ltd.

        = 0x0A4A
          Map Large, Inc.

        = 0x0A49
          Venture Research Inc.

        = 0x0A48
          JRC Mobility Inc.

        = 0x0A47
          The Wand Company Ltd

        = 0x0A46
          Beijing HC-Infinite Technology Limited

        = 0x0A45
          3SI Security Systems, Inc

        = 0x0A44
          Novidan, Inc.

        = 0x0A43
          Busch Systems International Inc.

        = 0x0A42
          Motionalysis, Inc.

        = 0x0A41
          OPEX Corporation

        = 0x0A40
          GEWISS S.p.A.

        = 0x0A3F
          Shenzhen Yopeak Optoelectronics Technology Co., Ltd.

        = 0x0A3E
          Hefei Yunlian Semiconductor Co., Ltd

        = 0x0A3D
          DELABIE

        = 0x0A3C
          Siteco GmbH

        = 0x0A3B
          Galileo Technology Limited

        = 0x0A3A
          Incotex Co. Ltd.

        = 0x0A39
          BLUETICKETING SRL

        = 0x0A38
          Bouffalo Lab (Nanjing)., Ltd.

        = 0x0A37
          2587702 Ontario Inc.

        = 0x0A36
          NGK SPARK PLUG CO., LTD.

        = 0x0A35
          safectory GmbH

        = 0x0A34
          Luxer Corporation

        = 0x0A33
          WMF AG

        = 0x0A32
          Pinnacle Technology, Inc.

        = 0x0A31
          Nevro Corp.

        = 0x0A30
          Air-Weigh

        = 0x0A2F
          Instamic, Inc.

        = 0x0A2E
          Zuma Array Limited

        = 0x0A2D
          Shenzhen Feasycom Technology Co., Ltd.

        = 0x0A2C
          Shenzhen H&T Intelligent Control Co., Ltd

        = 0x0A2B
          PaceBait IVS

        = 0x0A2A
          Yamaha Corporation

        = 0x0A29
          Worthcloud Technology Co.,Ltd

        = 0x0A28
          NanoFlex Power Corporation

        = 0x0A27
          AYU DEVICES PRIVATE LIMITED

        = 0x0A26
          Louis Vuitton

        = 0x0A25
          Eran Financial Services LLC

        = 0x0A24
          Atmosic Technologies, Inc.

        = 0x0A23
          BIXOLON CO.,LTD

        = 0x0A22
          DAIICHIKOSHO CO., LTD.

        = 0x0A21
          Apollogic Sp. z o.o.

        = 0x0A20
          Jiangxi Innotech Technology Co., Ltd

        = 0x0A1F
          DeVilbiss Healthcare LLC

        = 0x0A1E
          CombiQ AB

        = 0x0A1D
          API-K

        = 0x0A1C
          INPEAK S.C.

        = 0x0A1B
          Embrava Pty Ltd

        = 0x0A1A
          Link Labs, Inc.

        = 0x0A19
          Maxell, Ltd.

        = 0x0A18
          Cambridge Animal Technologies Ltd

        = 0x0A17
          Plume Design Inc

        = 0x0A16
          RIDE VISION LTD

        = 0x0A15
          Syng Inc

        = 0x0A14
          CROXEL, INC.

        = 0x0A13
          Tec4med LifeScience GmbH

        = 0x0A12
          Dyson Technology Limited

        = 0x0A11
          Sensolus

        = 0x0A10
          SUBARU Corporation

        = 0x0A0F
          LIXIL Corporation

        = 0x0A0E
          Roland Corporation

        = 0x0A0D
          Blue Peacock GmbH

        = 0x0A0C
          Shanghai Yidian Intelligent Technology Co., Ltd.

        = 0x0A0B
          SIANA Systems

        = 0x0A0A
          Volan Technology Inc.

        = 0x0A09
          ECCT

        = 0x0A08
          Oras Oy

        = 0x0A07
          Reflow Pty Ltd

        = 0x0A06
          Shanghai wuqi microelectronics Co.,Ltd

        = 0x0A05
          Southwire Company, LLC

        = 0x0A04
          Flosonics Medical

        = 0x0A03
          donutrobotics Co., Ltd.

        = 0x0A02
          Ayxon-Dynamics GmbH

        = 0x0A01
          Cleveron AS

        = 0x0A00
          Ampler Bikes OU

        = 0x09FF
          AIRSTAR

        = 0x09FE
          Lichtvision Engineering GmbH

        = 0x09FD
          Keep Technologies, Inc.

        = 0x09FC
          Confidex

        = 0x09FB
          TOITU CO., LTD.

        = 0x09FA
          Listen Technologies Corporation

        = 0x09F9
          Hangzhou Yaguan Technology Co. LTD

        = 0x09F8
          R.O. S.R.L.

        = 0x09F7
          SENSATEC Co., Ltd.

        = 0x09F6
          Mobile Action Technology Inc.

        = 0x09F5
          OKI Electric Industry Co., Ltd

        = 0x09F4
          Spectrum Technologies, Inc.

        = 0x09F3
          Beijing Zero Zero Infinity Technology Co.,Ltd.

        = 0x09F2
          Audeara Pty Ltd

        = 0x09F1
          OM Digital Solutions Corporation

        = 0x09F0
          WatchGas B.V.

        = 0x09EF
          Steinel Solutions AG

        = 0x09EE
          OJMAR SA

        = 0x09ED
          Sibel Inc.

        = 0x09EC
          Yukon advanced optics worldwide, UAB

        = 0x09EB
          KEAN ELECTRONICS PTY LTD

        = 0x09EA
          Athlos Oy

        = 0x09E9
          LumenRadio AB

        = 0x09E8
          Melange Systems Pvt. Ltd.

        = 0x09E7
          Kabushikigaisha HANERON

        = 0x09E6
          Masonite Corporation

        = 0x09E5
          Mobilogix

        = 0x09E4
          CPS AS

        = 0x09E3
          Friday Home Aps

        = 0x09E2
          Wuhan Linptech Co.,Ltd.

        = 0x09E1
          Tag-N-Trac Inc

        = 0x09E0
          Preddio Technologies Inc.

        = 0x09DF
          Magnus Technology Sdn Bhd

        = 0x09DE
          JLD Technology Solutions, LLC

        = 0x09DD
          Innoware Development AB

        = 0x09DC
          AON2 Ltd.

        = 0x09DB
          Bionic Avionics Inc.

        = 0x09DA
          Nagravision SA

        = 0x09D9
          VivoSensMedical GmbH

        = 0x09D8
          Synergy Tecnologia em Sistemas Ltda

        = 0x09D7
          Coyotta

        = 0x09D6
          EAR TEKNIK ISITME VE ODIOMETRI CIHAZLARI SANAYI VE TICARET ANONIM SIRKETI

        = 0x09D5
          GEAR RADIO ELECTRONICS CORP.

        = 0x09D4
          ORBIS Inc.

        = 0x09D3
          HeartHero, inc.

        = 0x09D2
          Temperature Sensitive Solutions Systems Sweden AB

        = 0x09D1
          ABLEPAY TECHNOLOGIES AS

        = 0x09D0
          Chess Wise B.V.

        = 0x09CF
          BlueStreak IoT, LLC

        = 0x09CE
          Julius Blum GmbH

        = 0x09CD
          Blyott

        = 0x09CC
          Senso4s d.o.o.

        = 0x09CB
          Hx Engineering, LLC

        = 0x09CA
          Mobitrace

        = 0x09C9
          CrowdGlow Ltd

        = 0x09C8
          XUNTONG

        = 0x09C7
          Combustion, LLC

        = 0x09C6
          Honor Device Co., Ltd.

        = 0x09C5
          HungYi Microelectronics Co.,Ltd.

        = 0x09C4
          UVISIO

        = 0x09C3
          JAPAN TOBACCO INC.

        = 0x09C2
          Universal Audio, Inc.

        = 0x09C1
          Rosewill

        = 0x09C0
          AnotherBrain inc.

        = 0x09BF
          Span.IO, Inc.

        = 0x09BE
          Vessel Ltd.

        = 0x09BD
          name: "Centre Suisse dElectronique et de Microtechnique SA"

        = 0x09BC
          Aerosens LLC

        = 0x09BB
          SkyStream Corporation

        = 0x09BA
          Elimo Engineering Ltd

        = 0x09B9
          SAVOY ELECTRONIC LIGHTING

        = 0x09B8
          PlayerData Limited

        = 0x09B7
          Bout Labs, LLC

        = 0x09B6
          Pegasus Technologies, Inc.

        = 0x09B5
          AUTEC Gesellschaft fuer Automationstechnik mbH

        = 0x09B4
          PentaLock Aps.

        = 0x09B3
          BlueX Microelectronics Corp Ltd.

        = 0x09B2
          DYPHI

        = 0x09B1
          BLINQY

        = 0x09B0
          Deublin Company, LLC

        = 0x09AF
          ifLink Open Community

        = 0x09AE
          Pozyx NV

        = 0x09AD
          Narhwall Inc.

        = 0x09AC
          Ambiq

        = 0x09AB
          DashLogic, Inc.

        = 0x09AA
          PHOTODYNAMIC INCORPORATED

        = 0x09A9
          Nippon Ceramic Co.,Ltd.

        = 0x09A8
          KHN Solutions LLC

        = 0x09A7
          Paybuddy ApS

        = 0x09A6
          BEIJING ELECTRIC VEHICLE CO.,LTD

        = 0x09A5
          Security Enhancement Systems, LLC

        = 0x09A4
          KUMHO ELECTRICS, INC

        = 0x09A3
          ARDUINO SA

        = 0x09A2
          ENGAGENOW DATA SCIENCES PRIVATE LIMITED

        = 0x09A1
          VOS Systems, LLC

        = 0x09A0
          Proof Diagnostics, Inc.

        = 0x099F
          Koya Medical, Inc.

        = 0x099E
          Step One Limited

        = 0x099D
          YKK AP Inc.

        = 0x099C
          deister electronic GmbH

        = 0x099B
          Sendum Wireless Corporation

        = 0x099A
          New Audio LLC

        = 0x0999
          eTactica ehf

        = 0x0998
          Pixie Dust Technologies, Inc.

        = 0x0997
          NextMind

        = 0x0996
          C. & E. Fein GmbH

        = 0x0995
          Bronkhorst High-Tech B.V.

        = 0x0994
          VT42 Pty Ltd

        = 0x0993
          Absolute Audio Labs B.V.

        = 0x0992
          Big Kaiser Precision Tooling Ltd

        = 0x0991
          Telenor ASA

        = 0x0990
          Anton Paar GmbH

        = 0x098F
          Aktiebolaget Regin

        = 0x098E
          ADVEEZ

        = 0x098D
          C3-WIRELESS, LLC

        = 0x098C
          bGrid B.V.

        = 0x098B
          Mequonic Engineering, S.L.

        = 0x098A
          Biovigil

        = 0x0989
          WIKA Alexander Wiegand SE & Co.KG

        = 0x0988
          BHM-Tech Produktionsgesellschaft m.b.H

        = 0x0987
          TSE BRAKES, INC.

        = 0x0986
          Cello Hill, LLC

        = 0x0985
          Lumos Health Inc.

        = 0x0984
          TeraTron GmbH

        = 0x0983
          Feedback Sports LLC

        = 0x0982
          ELPRO-BUCHS AG

        = 0x0981
          Bernard Krone Holding SE & Co.KG

        = 0x0980
          DEKRA TESTING AND CERTIFICATION, S.A.U.

        = 0x097F
          ISEMAR S.R.L.

        = 0x097E
          SonicSensory Inc

        = 0x097D
          CLB B.V.

        = 0x097C
          Thorley Industries, LLC

        = 0x097B
          CTEK Sweden AB

        = 0x097A
          CORE CORPORATION

        = 0x0979
          BIOTRONIK SE & Co. KG

        = 0x0978
          ZifferEins GmbH & Co. KG

        = 0x0977
          TOYOTA motor corporation

        = 0x0976
          Fauna Audio GmbH

        = 0x0975
          BlueIOT(Beijing) Technology Co.,Ltd

        = 0x0974
          ABEYE

        = 0x0973
          Popit Oy

        = 0x0972
          Closed Joint Stock Company "Zavod Flometr" ("Zavod Flometr" CJSC)

        = 0x0971
          GA

        = 0x0970
          IBA Dosimetry GmbH

        = 0x096F
          Lund Motion Products, Inc.

        = 0x096E
          Band Industries, inc.

        = 0x096D
          Gunwerks, LLC

        = 0x096C
          9374-7319 Quebec inc

        = 0x096B
          Guide ID B.V.

        = 0x096A
          dricos, Inc.

        = 0x0969
          Woan Technology (Shenzhen) Co., Ltd.

        = 0x0968
          Actev Motors, Inc.

        = 0x0967
          Neo Materials and Consulting Inc.

        = 0x0966
          PointGuard, LLC

        = 0x0965
          Asahi Kasei Corporation

        = 0x0964
          Countrymate Technology Limited

        = 0x0963
          Moonbird BV

        = 0x0962
          GL Solutions K.K.

        = 0x0961
          Linkura AB

        = 0x0960
          Sena Technologies Inc.

        = 0x095F
          NUANCE HEARING LTD

        = 0x095E
          BioEchoNet inc.

        = 0x095D
          Electronic Theatre Controls

        = 0x095C
          LogiLube, LLC

        = 0x095B
          Lismore Instruments Limited

        = 0x095A
          Selekt Bilgisayar, lletisim Urunleri lnsaat Sanayi ve Ticaret Limited Sirketi

        = 0x0959
          HerdDogg, Inc

        = 0x0958
          ZTE Corporation

        = 0x0957
          Ohsung Electronics

        = 0x0956
          Kerlink

        = 0x0955
          Breville Group

        = 0x0954
          Julbo

        = 0x0953
          LogiLube, LLC

        = 0x0952
          Apptricity Corporation

        = 0x0951
          PPRS

        = 0x0950
          Capetech

        = 0x094F
          Limited Liability Company "Mikrotikls"

        = 0x094E
          PassiveBolt, Inc.

        = 0x094D
          tkLABS INC.

        = 0x094C
          GimmiSys GmbH

        = 0x094B
          Kindeva Drug Delivery L.P.

        = 0x094A
          Zwift, Inc.

        = 0x0949
          Metronom Health Europe

        = 0x0948
          Wearable Link Limited

        = 0x0947
          First Light Technologies Ltd.

        = 0x0946
          AMC International Alfa Metalcraft Corporation AG

        = 0x0945
          Globe (Jiangsu) Co., Ltd

        = 0x0944
          Agitron d.o.o.

        = 0x0942
          TRANSSION HOLDINGS LIMITED

        = 0x0941
          Rivian Automotive, LLC

        = 0x0940
          Hero Workout GmbH

        = 0x093F
          JEPICO Corporation

        = 0x093E
          Catalyft Labs, Inc.

        = 0x093D
          Adolf Wuerth GmbH & Co KG

        = 0x093C
          Xenoma Inc.

        = 0x093B
          ENSESO LLC

        = 0x093A
          LinkedSemi Microelectronics (Xiamen) Co., Ltd

        = 0x0939
          ASTEM Co.,Ltd.

        = 0x0938
          Henway Technologies, LTD.

        = 0x0937
          RealThingks GmbH

        = 0x0936
          Elekon AG

        = 0x0935
          Reconnect, Inc.

        = 0x0934
          KiteSpring Inc.

        = 0x0933
          SRAM

        = 0x0932
          BarVision, LLC

        = 0x0931
          BREATHINGS Co., Ltd.

        = 0x0930
          James Walker RotaBolt Limited

        = 0x092F
          C.O.B.O. SpA

        = 0x092E
          PS GmbH

        = 0x092D
          Leggett & Platt, Incorporated

        = 0x092C
          PCI Private Limited

        = 0x092B
          TekHome

        = 0x092A
          Sappl Verwaltungs- und Betriebs GmbH

        = 0x0929
          Qingdao Haier Technology Co., Ltd.

        = 0x0928
          AiRISTA

        = 0x0927
          ROOQ GmbH

        = 0x0926
          Gooligum Technologies Pty Ltd

        = 0x0925
          Yukai Engineering Inc.

        = 0x0924
          Fundacion Tecnalia Research and Innovation

        = 0x0923
          JSB TECH PTE LTD

        = 0x0922
          Shanghai MXCHIP Information Technology Co., Ltd.

        = 0x0921
          KAHA PTE. LTD.

        = 0x0920
          Omnisense Limited

        = 0x091F
          Myzee Technology

        = 0x091E
          Melbot Studios, Sociedad Limitada

        = 0x091D
          Innokind, Inc.

        = 0x091C
          Oblamatik AG

        = 0x091B
          Luminostics, Inc.

        = 0x091A
          Albertronic BV

        = 0x0919
          NO SMD LIMITED

        = 0x0918
          Technosphere Labs Pvt. Ltd.

        = 0x0917
          ASR Microelectronics(ShenZhen)Co., Ltd.

        = 0x0916
          Ambient Sensors LLC

        = 0x0915
          Honda Motor Co., Ltd.

        = 0x0914
          INEO-SENSE

        = 0x0913
          Braveheart Wireless, Inc.

        = 0x0912
          Nerbio Medical Software Platforms Inc

        = 0x0911
          Douglas Lighting Controls Inc.

        = 0x0910
          ASR Microelectronics (Shanghai) Co., Ltd.

        = 0x090F
          VC Inc.

        = 0x090E
          OPTIMUSIOT TECH LLP

        = 0x090D
          IOT Invent GmbH

        = 0x090C
          Radiawave Technologies Co.,Ltd.

        = 0x090B
          EMBR labs, INC

        = 0x090A
          Zhuhai Hoksi Technology CO.,LTD

        = 0x0909
          70mai Co.,Ltd.

        = 0x0908
          Pinpoint Innovations Limited

        = 0x0907
          User Hello, LLC

        = 0x0906
          Scope Logistical Solutions

        = 0x0905
          Yandex Services AG

        = 0x0904
          SUNCORPORATION

        = 0x0903
          DATAMARS, Inc.

        = 0x0902
          TSC Auto-ID Technology Co., Ltd.

        = 0x0901
          Lucimed

        = 0x0900
          Beijing Zizai Technology Co., LTD.

        = 0x08FF
          Plastimold Products, Inc

        = 0x08FE
          Ketronixs Sdn Bhd

        = 0x08FD
          BioIntelliSense, Inc.

        = 0x08FC
          Hill-Rom

        = 0x08FB
          Darkglass Electronics Oy

        = 0x08FA
          Troo Corporation

        = 0x08F9
          Spacelabs Medical Inc.

        = 0x08F8
          instagrid GmbH

        = 0x08F7
          MTD Products Inc & Affiliates

        = 0x08F6
          Dermal Photonics Corporation

        = 0x08F5
          Tymtix Technologies Private Limited

        = 0x08F4
          Kodimo Technologies Company Limited

        = 0x08F3
          PSP - Pauli Services & Products GmbH

        = 0x08F2
          Microoled

        = 0x08F1
          The L.S. Starrett Company

        = 0x08F0
          Joovv, Inc.

        = 0x08EF
          Cumulus Digital Systems, Inc

        = 0x08EE
          Askey Computer Corp.

        = 0x08ED
          IMI Hydronic Engineering International SA

        = 0x08EC
          Denso Corporation

        = 0x08EB
          Beijing Big Moment Technology Co., Ltd.

        = 0x08EA
          COWBELL ENGINEERING CO.,LTD.

        = 0x08E9
          Taiwan Intelligent Home Corp.

        = 0x08E8
          Naonext

        = 0x08E7
          Barrot Technology Co.,Ltd.

        = 0x08E6
          Eneso Tecnologia de Adaptacion S.L.

        = 0x08E5
          Crowd Connected Ltd

        = 0x08E4
          Rashidov ltd

        = 0x08E3
          Republic Wireless, Inc.

        = 0x08E2
          Shenzhen Simo Technology co. LTD

        = 0x08E1
          KOZO KEIKAKU ENGINEERING Inc.

        = 0x08E0
          Philia Technology

        = 0x08DF
          IRIS OHYAMA CO.,LTD.

        = 0x08DE
          TE Connectivity Corporation

        = 0x08DD
          code-Q

        = 0x08DC
          SHENZHEN AUKEY E BUSINESS CO., LTD

        = 0x08DB
          Tertium Technology

        = 0x08DA
          Miridia Technology Incorporated

        = 0x08D9
          Pointr Labs Limited

        = 0x08D8
          WARES

        = 0x08D7
          Inovonics Corp

        = 0x08D6
          Nome Oy

        = 0x08D5
          KEYes

        = 0x08D4
          ADATA Technology Co., LTD.

        = 0x08D3
          Novel Bits, LLC

        = 0x08D2
          Virscient Limited

        = 0x08D1
          Sensovium Inc.

        = 0x08D0
          ESTOM Infotech Kft.

        = 0x08CF
          betternotstealmybike UG (with limited liability)

        = 0x08CE
          ZIMI CORPORATION

        = 0x08CD
          ifly

        = 0x08CC
          TGM TECHNOLOGY CO., LTD.

        = 0x08CB
          JT INNOVATIONS LIMITED

        = 0x08CA
          Nubia Technology Co.,Ltd.

        = 0x08C9
          Noventa AG

        = 0x08C8
          Liteboxer Technologies Inc.

        = 0x08C7
          Monadnock Systems Ltd.

        = 0x08C6
          Integra Optics Inc

        = 0x08C5
          J. Wagner GmbH

        = 0x08C4
          CellAssist, LLC

        = 0x08C3
          CHIPOLO d.o.o.

        = 0x08C2
          Lindinvent AB

        = 0x08C1
          Rayden.Earth LTD

        = 0x08C0
          Accent Advanced Systems SLU

        = 0x08BF
          SIRC Co., Ltd.

        = 0x08BE
          ubisys technologies GmbH

        = 0x08BD
          bf1systems limited

        = 0x08BC
          Prevayl Limited

        = 0x08BB
          Tokai-rika co.,ltd.

        = 0x08BA
          HYPER ICE, INC.

        = 0x08B9
          U-Shin Ltd.

        = 0x08B8
          Check Technology Solutions LLC

        = 0x08B7
          ABB Inc

        = 0x08B6
          Boehringer Ingelheim Vetmedica GmbH

        = 0x08B5
          TransferFi

        = 0x08B4
          Sengled Co., Ltd.

        = 0x08B3
          IONIQ Skincare GmbH & Co. KG

        = 0x08B2
          PF SCHWEISSTECHNOLOGIE GMBH

        = 0x08B1
          CORE|vision BV

        = 0x08B0
          Trivedi Advanced Technologies LLC

        = 0x08AF
          Polidea Sp. z o.o.

        = 0x08AE
          Moticon ReGo AG

        = 0x08AD
          Kayamatics Limited

        = 0x08AC
          Topre Corporation

        = 0x08AB
          Coburn Technology, LLC

        = 0x08AA
          SZ DJI TECHNOLOGY CO.,LTD

        = 0x08A9
          Fraunhofer IIS

        = 0x08A8
          Shanghai Kfcube Inc

        = 0x08A7
          TGR 1.618 Limited

        = 0x08A6
          Intelligenceworks Inc.

        = 0x08A5
          UMEHEAL Ltd

        = 0x08A4
          Realme Chongqing Mobile Telecommunications Corp., Ltd.

        = 0x08A3
          Hoffmann SE

        = 0x08A2
          Epic Systems Co., Ltd.

        = 0x08A1
          EXEO TECH CORPORATION

        = 0x08A0
          Aclara Technologies LLC

        = 0x089F
          Witschi Electronic Ltd

        = 0x089E
          i-SENS, inc.

        = 0x089D
          J-J.A.D.E. Enterprise LLC

        = 0x089C
          Embedded Devices Co. Company

        = 0x089B
          Saucon Technologies

        = 0x089A
          Private limited company "Teltonika"

        = 0x0899
          SFS unimarket AG

        = 0x0898
          Sensibo, Inc.

        = 0x0897
          Current Lighting Solutions LLC

        = 0x0896
          Nokian Renkaat Oyj

        = 0x0895
          Gimer medical

        = 0x0894
          EPIFIT

        = 0x0893
          Maytronics Ltd

        = 0x0892
          Ingenieurbuero Birnfeld UG (haftungsbeschraenkt)

        = 0x0891
          SmartWireless GmbH & Co. KG

        = 0x0890
          NICHIEI INTEC CO., LTD.

        = 0x088F
          Tait International Limited

        = 0x088E
          GIGA-TMS INC

        = 0x088D
          Soliton Systems K.K.

        = 0x088C
          GB Solution co.,Ltd

        = 0x088B
          Tricorder Arraay Technologies LLC

        = 0x088A
          sclak s.r.l.

        = 0x0889
          XANTHIO

        = 0x0888
          EnPointe Fencing Pty Ltd

        = 0x0887
          Hydro-Gear Limited Partnership

        = 0x0886
          Movella Technologies B.V.

        = 0x0885
          LEVOLOR INC

        = 0x0884
          Controlid Industria, Comercio de Hardware e Servicos de Tecnologia Ltda

        = 0x0883
          Wintersteiger AG

        = 0x0882
          PSYONIC, Inc.

        = 0x0881
          Optalert

        = 0x0880
          imagiLabs AB

        = 0x087F
          Phillips Connect Technologies LLC

        = 0x087E
          1bar.net Limited

        = 0x087D
          Konftel AB

        = 0x087C
          Crosscan GmbH

        = 0x087B
          BYSTAMP

        = 0x087A
          ZRF, LLC

        = 0x0879
          MIZUNO Corporation

        = 0x0878
          The Chamberlain Group, Inc.

        = 0x0877
          Tome, Inc.

        = 0x0876
          SmartResQ ApS

        = 0x0875
          Berner International LLC

        = 0x0874
          Treegreen Limited

        = 0x0873
          Innophase Incorporated

        = 0x0872
          11 Health & Technologies Limited

        = 0x0871
          Dension Elektronikai Kft.

        = 0x0870
          Wyze Labs, Inc

        = 0x086F
          Trackunit A/S

        = 0x086E
          Vorwerk Elektrowerke GmbH & Co. KG

        = 0x086D
          Biometrika d.o.o.

        = 0x086C
          Revvo Technologies, Inc.

        = 0x086B
          Pacific Track, LLC

        = 0x086A
          Odic Incorporated

        = 0x0869
          EVVA Sicherheitstechnologie GmbH

        = 0x0868
          WIOsense GmbH & Co. KG

        = 0x0867
          Western Digital Techologies, Inc.

        = 0x0866
          LAONZ Co.,Ltd

        = 0x0865
          Emergency Lighting Products Limited

        = 0x0864
          Rafaelmicro

        = 0x0863
          Yo-tronics Technology Co., Ltd.

        = 0x0862
          SmartDrive

        = 0x0861
          SmartSensor Labs Ltd

        = 0x0860
          Alflex Products B.V.

        = 0x085F
          COMPEGPS TEAM,SOCIEDAD LIMITADA

        = 0x085E
          Krog Systems LLC

        = 0x085D
          Guilin Zhishen Information Technology Co.,Ltd.

        = 0x085C
          ACOS CO.,LTD.

        = 0x085B
          Nisshinbo Micro Devices Inc.

        = 0x085A
          DAKATECH

        = 0x0859
          BlueUp

        = 0x0858
          SOUNDBOKS

        = 0x0857
          Parsyl Inc

        = 0x0856
          Canopy Growth Corporation

        = 0x0855
          Helios Sports, Inc.

        = 0x0854
          Tap Sound System

        = 0x0853
          Pektron Group Limited

        = 0x0852
          Cognosos, Inc.

        = 0x0851
          Subeca, Inc.

        = 0x0850
          Yealink (Xiamen) Network Technology Co.,LTD

        = 0x084F
          Embedded Fitness B.V.

        = 0x084E
          Carol Cole Company

        = 0x084D
          SafePort

        = 0x084C
          ORSO Inc.

        = 0x084B
          Biotechware SRL

        = 0x084A
          ARCOM

        = 0x0849
          Dopple Technologies B.V.

        = 0x0848
          JUJU JOINTS CANADA CORP.

        = 0x0847
          DNANUDGE LIMITED

        = 0x0846
          USound GmbH

        = 0x0845
          Dometic Corporation

        = 0x0844
          Pepperl + Fuchs GmbH

        = 0x0843
          FRAGRANCE DELIVERY TECHNOLOGIES LTD

        = 0x0842
          Tangshan HongJia electronic technology co., LTD.

        = 0x0841
          General Luminaire (Shanghai) Co., Ltd.

        = 0x0840
          Down Range Systems LLC

        = 0x083F
          D-Link Corp.

        = 0x083E
          Zorachka LTD

        = 0x083D
          Tokenize, Inc.

        = 0x083C
          BeerTech LTD

        = 0x083B
          Piaggio Fast Forward

        = 0x083A
          BPW Bergische Achsen Kommanditgesellschaft

        = 0x0839
          A puissance 3

        = 0x0838
          Etymotic Research, Inc.

        = 0x0837
          vivo Mobile Communication Co., Ltd.

        = 0x0836
          Bitwards Oy

        = 0x0835
          Canopy Growth Corporation

        = 0x0834
          RIKEN KEIKI CO., LTD.,

        = 0x0833
          Conneqtech B.V.

        = 0x0832
          Intermotive,Inc.

        = 0x0831
          Foxble, LLC

        = 0x0830
          Core Health and Fitness LLC

        = 0x082F
          Blippit AB

        = 0x082E
          ABB S.p.A.

        = 0x082D
          INCUS PERFORMANCE LTD.

        = 0x082C
          INGICS TECHNOLOGY CO., LTD.

        = 0x082B
          shenzhen fitcare electronics Co.,Ltd

        = 0x082A
          Mitutoyo Corporation

        = 0x0829
          HEXAGON METROLOGY DIVISION ROMER

        = 0x0828
          Shanghai Suisheng Information Technology Co., Ltd.

        = 0x0827
          Kickmaker

        = 0x0826
          Hyundai Motor Company

        = 0x0825
          CME PTE. LTD.

        = 0x0824
          8Power Limited

        = 0x0823
          Nexite Ltd

        = 0x0822
          adafruit industries

        = 0x0821
          INOVA Geophysical, Inc.

        = 0x0820
          Brilliant Home Technology, Inc.

        = 0x081F
          eSenseLab LTD

        = 0x081E
          iNFORM Technology GmbH

        = 0x081D
          Potrykus Holdings and Development LLC

        = 0x081C
          Bobrick Washroom Equipment, Inc.

        = 0x081B
          DIM3

        = 0x081A
          Shenzhen Conex

        = 0x0819
          Hunter Douglas Inc

        = 0x0818
          tatwah SA

        = 0x0817
          Wangs Alliance Corporation

        = 0x0816
          SPICA SYSTEMS LLC

        = 0x0815
          SKC Inc

        = 0x0814
          Ossur hf.

        = 0x0813
          Flextronics International USA Inc.

        = 0x0812
          Mstream Technologies., Inc.

        = 0x0811
          Becker Antriebe GmbH

        = 0x0810
          LECO Corporation

        = 0x080F
          Paradox Engineering SA

        = 0x080E
          TATTCOM LLC

        = 0x080D
          Azbil Co.

        = 0x080C
          Ingy B.V.

        = 0x080B
          Nanoleaf Canada Limited

        = 0x080A
          Altaneos

        = 0x0809
          Trulli Audio

        = 0x0808
          SISTEMAS KERN, SOCIEDAD ANÃ“MINA

        = 0x0807
          ECD Electronic Components GmbH Dresden

        = 0x0806
          TYRI Sweden AB

        = 0x0805
          Urbanminded Ltd

        = 0x0804
          Andon Health Co.,Ltd

        = 0x0803
          Domintell s.a.

        = 0x0802
          NantSound, Inc.

        = 0x0801
          CRONUS ELECTRONICS LTD

        = 0x0800
          Optek

        = 0x07FF
          maxon motor ltd.

        = 0x07FE
          BIROTA

        = 0x07FD
          JSK CO., LTD.

        = 0x07FC
          Renault SA

        = 0x07FB
          Access Co., Ltd

        = 0x07FA
          Klipsch Group, Inc.

        = 0x07F9
          Direct Communication Solutions, Inc.

        = 0x07F8
          quip NYC Inc.

        = 0x07F7
          Cesar Systems Ltd.

        = 0x07F6
          Shenzhen TonliScience and Technology Development Co.,Ltd

        = 0x07F5
          Byton North America Corporation

        = 0x07F4
          MEDIRLAB Orvosbiologiai Fejleszto Korlatolt Felelossegu Tarsasag

        = 0x07F3
          DIGISINE ENERGYTECH CO. LTD.

        = 0x07F2
          SERENE GROUP, INC

        = 0x07F1
          Zimi Innovations Pty Ltd

        = 0x07F0
          e-moola.com Pty Ltd

        = 0x07EF
          Aktiebolaget Sandvik Coromant

        = 0x07EE
          KidzTek LLC

        = 0x07ED
          Joule IQ, INC.

        = 0x07EC
          Frecce LLC

        = 0x07EB
          NOVABASE S.R.L.

        = 0x07EA
          ShapeLog, Inc.

        = 0x07E9
          HÃ¤fele GmbH & Co KG

        = 0x07E8
          Packetcraft, Inc.

        = 0x07E7
          Komfort IQ, Inc.

        = 0x07E6
          Waybeyond Limited

        = 0x07E5
          Minut, Inc.

        = 0x07E4
          Geeksme S.L.

        = 0x07E3
          Airoha Technology Corp.

        = 0x07E2
          Alfred Kaercher SE & Co. KG

        = 0x07E1
          Lucie Labs

        = 0x07E0
          Edifier International Limited

        = 0x07DF
          Snap-on Incorporated

        = 0x07DE
          Unlimited Engineering SL

        = 0x07DD
          Linear Circuits

        = 0x07DC
          ThingOS GmbH & Co KG

        = 0x07DB
          Remedee Labs

        = 0x07DA
          STARLITE Co., Ltd.

        = 0x07D9
          Micro-Design, Inc.

        = 0x07D8
          SOLUTIONS AMBRA INC.

        = 0x07D7
          Nanjing Qinheng Microelectronics Co., Ltd

        = 0x07D6
          ecobee Inc.

        = 0x07D5
          hoots classic GmbH

        = 0x07D4
          Kano Computing Limited

        = 0x07D3
          LIVNEX Co.,Ltd.

        = 0x07D2
          React Accessibility Limited

        = 0x07D1
          Shanghai Panchip Microelectronics Co., Ltd

        = 0x07D0
          Hangzhou Tuya Information  Technology Co., Ltd

        = 0x07CF
          NeoSensory, Inc.

        = 0x07CE
          Shanghai Top-Chip Microelectronics Tech. Co., LTD

        = 0x07CD
          Smart Wave Technologies Canada Inc

        = 0x07CC
          Barnacle Systems Inc.

        = 0x07CB
          West Pharmaceutical Services, Inc.

        = 0x07CA
          Modul-System HH AB

        = 0x07C9
          Skullcandy, Inc.

        = 0x07C8
          WRLDS Creations AB

        = 0x07C7
          iaconicDesign Inc.

        = 0x07C6
          Bluenetics GmbH

        = 0x07C5
          June Life, Inc.

        = 0x07C4
          Johnson Health Tech NA

        = 0x07C3
          CIMTechniques, Inc.

        = 0x07C2
          Radinn AB

        = 0x07C1
          A.W. Chesterton Company

        = 0x07C0
          Biral AG

        = 0x07BF
          REGULA Ltd.

        = 0x07BE
          Axentia Technologies AB

        = 0x07BD
          Genedrive Diagnostics Ltd

        = 0x07BC
          KD CIRCUITS LLC

        = 0x07BB
          EPIC S.R.L.

        = 0x07BA
          Battery-Biz Inc.

        = 0x07B9
          Epona Biotec Limited

        = 0x07B8
          iSwip

        = 0x07B7
          ETABLISSEMENTS GEORGES RENAULT

        = 0x07B6
          Soundbrenner Limited

        = 0x07B5
          CRONO CHIP, S.L.

        = 0x07B4
          Hormann KG Antriebstechnik

        = 0x07B3
          2N TELEKOMUNIKACE a.s.

        = 0x07B2
          Moeco IOT Inc.

        = 0x07B1
          Thomas Dynamics, LLC

        = 0x07B0
          GV Concepts Inc.

        = 0x07AF
          Hong Kong Bouffalo Lab Limited

        = 0x07AE
          Aurea Solucoes Tecnologicas Ltda.

        = 0x07AD
          New H3C Technologies Co.,Ltd

        = 0x07AC
          LoupeDeck Oy

        = 0x07AB
          Granite River Solutions, Inc.

        = 0x07AA
          The Kroger Co.

        = 0x07A9
          Bruel & Kjaer Sound & Vibration

        = 0x07A8
          conbee GmbH

        = 0x07A7
          Zume, Inc.

        = 0x07A6
          Musen Connect, Inc.

        = 0x07A5
          RAB Lighting, Inc.

        = 0x07A4
          Xiamen Mage Information Technology Co., Ltd.

        = 0x07A3
          Comcast Cable

        = 0x07A2
          Roku, Inc.

        = 0x07A1
          Apollo Neuroscience, Inc.

        = 0x07A0
          Regent Beleuchtungskorper AG

        = 0x079F
          Pune Scientific LLP

        = 0x079E
          Smartloxx GmbH

        = 0x079D
          Digibale Pty Ltd

        = 0x079C
          Sky UK Limited

        = 0x079B
          CST ELECTRONICS (PROPRIETARY) LIMITED

        = 0x079A
          GuangDong Oppo Mobile Telecommunications Corp., Ltd.

        = 0x0799
          PlantChoir Inc.

        = 0x0798
          HoloKit, Inc.

        = 0x0797
          Water-i.d. GmbH

        = 0x0796
          StarLeaf Ltd

        = 0x0795
          GASTEC CORPORATION

        = 0x0794
          The Coca-Cola Company

        = 0x0793
          AEV spol. s r.o.

        = 0x0792
          Cricut, Inc.

        = 0x0791
          Scosche Industries, Inc.

        = 0x0790
          KOMPAN A/S

        = 0x078F
          Hanna Instruments, Inc.

        = 0x078E
          FUJIMIC NIIGATA, INC.

        = 0x078D
          Cybex GmbH

        = 0x078C
          MINIBREW HOLDING B.V

        = 0x078B
          Optikam Tech Inc.

        = 0x078A
          The Wildflower Foundation

        = 0x0789
          PCB Piezotronics, Inc.

        = 0x0788
          BubblyNet, LLC

        = 0x0787
          Pangaea Solution

        = 0x0786
          HLP Controls Pty Limited

        = 0x0785
          O2 Micro, Inc.

        = 0x0784
          audifon GmbH & Co. KG

        = 0x0783
          ESEMBER LIMITED LIABILITY COMPANY

        = 0x0782
          DeviceDrive AS

        = 0x0781
          Qingping Technology (Beijing) Co., Ltd.

        = 0x0780
          Finch Technologies Ltd.

        = 0x077F
          Glenview Software Corporation

        = 0x077E
          Sparkage Inc.

        = 0x077D
          Sensority, s.r.o.

        = 0x077C
          radius co., ltd.

        = 0x077B
          AmaterZ, Inc.

        = 0x077A
          Niruha Systems Private Limited

        = 0x0779
          Loopshore Oy

        = 0x0778
          KOAMTAC INC.

        = 0x0777
          Cue

        = 0x0776
          Cyber Transport Control GmbH

        = 0x0775
          4eBusiness GmbH

        = 0x0774
          C-MAX Asia Limited

        = 0x0773
          Echoflex Solutions Inc.

        = 0x0772
          Thirdwayv Inc.

        = 0x0771
          Corvex Connected Safety

        = 0x0770
          InnoCon Medical ApS

        = 0x076F
          Successful Endeavours Pty Ltd

        = 0x076E
          WuQi technologies, Inc.

        = 0x076D
          Graesslin GmbH

        = 0x076C
          Noodle Technology inc

        = 0x076B
          Engineered Medical Technologies

        = 0x076A
          Dmac Mobile Developments, LLC

        = 0x0769
          Force Impact Technologies

        = 0x0768
          Peloton Interactive Inc.

        = 0x0767
          NITTO DENKO ASIA TECHNICAL CENTRE PTE. LTD.

        = 0x0766
          ART AND PROGRAM, INC.

        = 0x0765
          Voxx International

        = 0x0764
          WWZN Information Technology Company Limited

        = 0x0763
          PIKOLIN S.L.

        = 0x0762
          TerOpta Ltd

        = 0x0761
          Mantis Tech LLC

        = 0x0760
          Vimar SpA

        = 0x075F
          Remote Solution Co., LTD.

        = 0x075E
          Katerra Inc.

        = 0x075D
          RHOMBUS SYSTEMS, INC.

        = 0x075C
          Antitronics Inc.

        = 0x075B
          Smart Sensor Devices AB

        = 0x075A
          HARMAN CO.,LTD.

        = 0x0759
          Shanghai InGeek Cyber Security Co., Ltd.

        = 0x0758
          umanSense AB

        = 0x0757
          ELA Innovation

        = 0x0756
          Lumens For Less, Inc

        = 0x0755
          Brother Industries, Ltd

        = 0x0754
          Michael Parkin

        = 0x0753
          JLG Industries, Inc.

        = 0x0752
          Elatec GmbH

        = 0x0751
          Changsha JEMO IC Design Co.,Ltd

        = 0x0750
          Hamilton Professional Services of Canada Incorporated

        = 0x074F
          MEDIATECH S.R.L.

        = 0x074E
          EAGLE DETECTION SA

        = 0x074D
          Amtech Systems, LLC

        = 0x074C
          iopool s.a.

        = 0x074B
          Sarvavid Software Solutions LLP

        = 0x074A
          Illusory Studios LLC

        = 0x0749
          DIAODIAO (Beijing) Technology Co., Ltd.

        = 0x0748
          GuangZhou KuGou Computer Technology Co.Ltd

        = 0x0747
          OR Technologies Pty Ltd

        = 0x0746
          Seitec Elektronik GmbH

        = 0x0745
          WIZNOVA, Inc.

        = 0x0744
          SOCOMEC

        = 0x0743
          Sanofi

        = 0x0742
          DML LLC

        = 0x0741
          MAC SRL

        = 0x0740
          HITIQ LIMITED

        = 0x073F
          Beijing Unisoc Technologies Co., Ltd.

        = 0x073E
          Bluepack S.R.L.

        = 0x073D
          Beijing Hao Heng Tian Tech Co., Ltd.

        = 0x073C
          Acubit ApS

        = 0x073B
          Fantini Cosmi s.p.a.

        = 0x073A
          Chandler Systems Inc.

        = 0x0739
          Jiangsu Qinheng Co., Ltd.

        = 0x0738
          Glass Security Pte Ltd

        = 0x0737
          LLC Navitek

        = 0x0736
          Luna XIO, Inc.

        = 0x0735
          UpRight Technologies LTD

        = 0x0734
          DiUS Computing Pty Ltd

        = 0x0733
          Iguanavation, Inc.

        = 0x0732
          Dairy Tech, Inc.

        = 0x0731
          ABLIC Inc.

        = 0x0730
          Wildlife Acoustics, Inc.

        = 0x072F
          OnePlus Electronics (Shenzhen) Co., Ltd.

        = 0x072E
          Open Platform Systems LLC

        = 0x072D
          Safera Oy

        = 0x072C
          GWA Hygiene GmbH

        = 0x072B
          Bitkey Inc.

        = 0x072A
          JMR embedded systems GmbH

        = 0x0729
          SwaraLink Technologies

        = 0x0728
          Eli Lilly and Company

        = 0x0727
          STALKIT AS

        = 0x0726
          PHC Corporation

        = 0x0725
          Tedee Sp. z o.o.

        = 0x0724
          Guangzhou SuperSound Information Technology Co.,Ltd

        = 0x0723
          Ford Motor Company

        = 0x0722
          Xiamen Eholder Electronics Co.Ltd

        = 0x0721
          Clover Network, Inc.

        = 0x0720
          Oculeve, Inc.

        = 0x071F
          Dongguan Liesheng Electronic Co.Ltd

        = 0x071E
          DONGGUAN HELE ELECTRONICS CO., LTD

        = 0x071D
          exoTIC Systems

        = 0x071C
          F5 Sports, Inc

        = 0x071B
          Precor

        = 0x071A
          REVSMART WEARABLE HK CO LTD

        = 0x0719
          COREIOT PTY LTD

        = 0x0718
          IDIBAIX enginneering

        = 0x0717
          iQsquare BV

        = 0x0716
          Altonics

        = 0x0715
          MBARC LABS Inc

        = 0x0714
          MindPeace Safety LLC

        = 0x0713
          Respiri Limited

        = 0x0712
          Bull Group Company Limited

        = 0x0711
          ABAX AS

        = 0x0710
          Audiodo AB

        = 0x070F
          California Things Inc.

        = 0x070E
          FiveCo Sarl

        = 0x070D
          SmartSnugg Pty Ltd

        = 0x070C
          Beijing Winner Microelectronics Co.,Ltd

        = 0x070B
          Element Products, Inc.

        = 0x070A
          Huf HÃ¼lsbeck & FÃ¼rst GmbH & Co. KG

        = 0x0709
          Carewear Corp.

        = 0x0708
          Be Interactive Co., Ltd

        = 0x0707
          Essity Hygiene and Health Aktiebolag

        = 0x0706
          Wernher von Braun Center for ASdvanced Research

        = 0x0705
          AB Electrolux

        = 0x0704
          JBX Designs Inc.

        = 0x0703
          Beijing Jingdong Century Trading Co., Ltd.

        = 0x0702
          Akciju sabiedriba "SAF TEHNIKA"

        = 0x0701
          PAFERS TECH

        = 0x0700
          TraqFreq LLC

        = 0x06FF
          Redpine Signals Inc

        = 0x06FE
          Mahr GmbH

        = 0x06FD
          ESS Embedded System Solutions Inc.

        = 0x06FC
          Tom Communication Industrial Co.,Ltd.

        = 0x06FB
          Sartorius AG

        = 0x06FA
          Enequi AB

        = 0x06F9
          happybrush GmbH

        = 0x06F8
          BodyPlus Technology Co.,Ltd

        = 0x06F7
          WILKA Schliesstechnik GmbH

        = 0x06F6
          Vitulo Plus BV

        = 0x06F5
          Vigil Technologies Inc.

        = 0x06F4
          TouchÃ© Technology Ltd

        = 0x06F3
          Alfred International Inc.

        = 0x06F2
          Trapper Data AB

        = 0x06F1
          Shibutani Co., Ltd.

        = 0x06F0
          Chargy Technologies, SL

        = 0x06EF
          ALCARE Co., Ltd.

        = 0x06EE
          Avantis Systems Limited

        = 0x06ED
          J Neades Ltd

        = 0x06EC
          Sigur

        = 0x06EB
          Houston Radar LLC

        = 0x06EA
          SafeLine Sweden AB

        = 0x06E9
          Zmartfun Electronics, Inc.

        = 0x06E8
          Almendo Technologies GmbH

        = 0x06E7
          VELUX A/S

        = 0x06E6
          NIHON DENGYO KOUSAKU

        = 0x06E5
          OPTEX CO.,LTD.

        = 0x06E4
          Aluna

        = 0x06E3
          Spinlock Ltd

        = 0x06E2
          Alango Technologies Ltd

        = 0x06E1
          Milestone AV Technologies LLC

        = 0x06E0
          Avaya Inc.

        = 0x06DF
          HLI Solutions Inc.

        = 0x06DE
          Navcast, Inc.

        = 0x06DD
          Intellithings Ltd.

        = 0x06DC
          Industrial Network Controls, LLC

        = 0x06DB
          Automatic Labs, Inc.

        = 0x06DA
          Zliide Technologies ApS

        = 0x06D9
          Shanghai Mountain View Silicon Co.,Ltd.

        = 0x06D8
          AW Company

        = 0x06D7
          FUBA Automotive Electronics GmbH

        = 0x06D6
          JCT Healthcare Pty Ltd

        = 0x06D5
          Sensirion AG

        = 0x06D4
          DYNAKODE TECHNOLOGY PRIVATE LIMITED

        = 0x06D3
          TriTeq Lock and Security, LLC

        = 0x06D2
          CeoTronics AG

        = 0x06D1
          Meyer Sound Laboratories, Incorporated

        = 0x06D0
          Etekcity Corporation

        = 0x06CF
          Belparts N.V.

        = 0x06CE
          FIOR & GENTZ

        = 0x06CD
          DIG Corporation

        = 0x06CC
          Dongguan SmartAction Technology Co.,Ltd.

        = 0x06CB
          Dyeware, LLC

        = 0x06CA
          Shenzhen Zhongguang Infotech Technology Development Co., Ltd

        = 0x06C9
          MYLAPS B.V.

        = 0x06C8
          Storz & Bickel GmbH & Co. KG

        = 0x06C7
          Somatix Inc

        = 0x06C6
          Simm Tronic Limited

        = 0x06C5
          Urban Compass, Inc

        = 0x06C4
          Dream Labs GmbH

        = 0x06C3
          King I Electronics.Co.,Ltd

        = 0x06C2
          Measurlogic Inc.

        = 0x06C1
          Alarm.com Holdings, Inc

        = 0x06C0
          CAME S.p.A.

        = 0x06BF
          Delcom Products Inc.

        = 0x06BE
          HitSeed Oy

        = 0x06BD
          ABB Oy

        = 0x06BC
          TWS Srl

        = 0x06BB
          Leaftronix Analogic Solutions Private Limited

        = 0x06BA
          Beaconzone Ltd

        = 0x06B9
          Beflex Inc.

        = 0x06B8
          ShadeCraft, Inc

        = 0x06B7
          iCOGNIZE GmbH

        = 0x06B6
          Sociometric Solutions, Inc.

        = 0x06B5
          Wabilogic Ltd.

        = 0x06B4
          Sencilion Oy

        = 0x06B3
          The Hablab ApS

        = 0x06B2
          Tussock Innovation 2013 Limited

        = 0x06B1
          SimpliSafe, Inc.

        = 0x06B0
          BRK Brands, Inc.

        = 0x06AF
          Shoof Technologies

        = 0x06AE
          SenseQ Inc.

        = 0x06AD
          InnovaSea Systems Inc.

        = 0x06AC
          Ingchips Technology Co., Ltd.

        = 0x06AB
          HMS Industrial Networks AB

        = 0x06AA
          Produal Oy

        = 0x06A9
          Soundmax Electronics Limited

        = 0x06A8
          GD Midea Air-Conditioning Equipment Co., Ltd.

        = 0x06A7
          Chipsea Technologies (ShenZhen) Corp.

        = 0x06A6
          Roambee Corporation

        = 0x06A5
          TEKZITEL PTY LTD

        = 0x06A4
          LIMNO Co. Ltd.

        = 0x06A3
          Nymbus, LLC

        = 0x06A2
          Globalworx GmbH

        = 0x06A1
          Cardo Systems, Ltd

        = 0x06A0
          OBIQ Location Technology Inc.

        = 0x069F
          FlowMotion Technologies AS

        = 0x069E
          Delta Electronics, Inc.

        = 0x069D
          Vakaros LLC

        = 0x069C
          Noomi AB

        = 0x069B
          Dragonchip Limited

        = 0x069A
          Adero, Inc.

        = 0x0699
          RandomLab SAS

        = 0x0698
          Wood IT Security, LLC

        = 0x0697
          Stemco Products Inc

        = 0x0696
          Gunakar Private Limited

        = 0x0695
          Koki Holdings Co., Ltd.

        = 0x0694
          T&A Laboratories LLC

        = 0x0693
          Hach - Danaher

        = 0x0692
          Georg Fischer AG

        = 0x0691
          Curie Point AB

        = 0x0690
          Eccrine Systems, Inc.

        = 0x068F
          JRM Group Limited

        = 0x068E
          Razer Inc.

        = 0x068D
          JetBeep Inc.

        = 0x068C
          Changzhou Sound Dragon Electronics and Acoustics Co., Ltd

        = 0x068B
          Jiangsu Teranovo Tech Co., Ltd.

        = 0x068A
          Raytac Corporation

        = 0x0689
          Tacx b.v.

        = 0x0688
          Amsted Digital Solutions Inc.

        = 0x0687
          Cherry GmbH

        = 0x0686
          inQs Co., Ltd.

        = 0x0685
          Greenwald Industries

        = 0x0684
          Dermalapps, LLC

        = 0x0683
          Eltako GmbH

        = 0x0682
          Photron Limited

        = 0x0681
          Trade FIDES a.s.

        = 0x0680
          Mannkind Corporation

        = 0x067F
          NETGRID S.N.C. DI BISSOLI MATTEO, CAMPOREALE SIMONE, TOGNETTI FEDERICO

        = 0x067E
          MbientLab Inc

        = 0x067D
          Form Athletica Inc.

        = 0x067C
          Tile, Inc.

        = 0x067B
          I.FARM, INC.

        = 0x067A
          The Energy Conservatory, Inc.

        = 0x0679
          4iiii Innovations Inc.

        = 0x0678
          SABIK Offshore GmbH

        = 0x0677
          Innovation First, Inc.

        = 0x0676
          Expai Solutions Private Limited

        = 0x0675
          Deco Enterprises, Inc.

        = 0x0674
          BeSpoon

        = 0x0673
          Innova Ideas Limited

        = 0x0672
          Kopi

        = 0x0671
          Buzz Products Ltd.

        = 0x0670
          Gema Switzerland GmbH

        = 0x066F
          Hug Technology Ltd

        = 0x066E
          Eurotronik Kranj d.o.o.

        = 0x066D
          Venso EcoSolutions AB

        = 0x066C
          Ztove ApS

        = 0x066B
          DewertOkin GmbH

        = 0x066A
          Brady Worldwide Inc.

        = 0x0669
          Livanova USA, Inc.

        = 0x0668
          Bleb Technology srl

        = 0x0667
          Spark Technology Labs Inc.

        = 0x0666
          WTO Werkzeug-Einrichtungen GmbH

        = 0x0665
          Pure International Limited

        = 0x0664
          RHA TECHNOLOGIES LTD

        = 0x0663
          Advanced Telemetry Systems, Inc.

        = 0x0662
          Particle Industries, Inc.

        = 0x0661
          Mode Lighting Limited

        = 0x0660
          RTC Industries, Inc.

        = 0x065F
          Ricoh Company Ltd

        = 0x065E
          Alo AB

        = 0x065D
          Panduit Corp.

        = 0x065C
          PixArt Imaging Inc.

        = 0x065B
          Sesam Solutions BV

        = 0x065A
          Zound Industries International AB

        = 0x0659
          UnSeen Technologies Oy

        = 0x0658
          Payex Norge AS

        = 0x0657
          Meshtronix Limited

        = 0x0656
          ZhuHai AdvanPro Technology Company Limited

        = 0x0655
          Renishaw PLC

        = 0x0654
          Ledlenser GmbH & Co. KG

        = 0x0653
          Meggitt SA

        = 0x0652
          ITZ Innovations- und Technologiezentrum GmbH

        = 0x0651
          Stasis Labs, Inc.

        = 0x0650
          Coravin, Inc.

        = 0x064F
          Digital Matter Pty Ltd

        = 0x064E
          KRUXWorks Technologies Private Limited

        = 0x064D
          iLOQ Oy

        = 0x064C
          Zumtobel Group AG

        = 0x064B
          Scale-Tec, Ltd

        = 0x064A
          Open Research Institute, Inc.

        = 0x0649
          Ryeex Technology Co.,Ltd.

        = 0x0648
          Ultune Technologies

        = 0x0647
          MED-EL

        = 0x0646
          SGV Group Holding GmbH & Co. KG

        = 0x0645
          BM3

        = 0x0644
          Apogee Instruments

        = 0x0643
          makita corporation

        = 0x0642
          Bluetrum Technology Co.,Ltd

        = 0x0641
          Revenue Collection Systems FRANCE SAS

        = 0x0640
          Dish Network LLC

        = 0x063F
          LDL TECHNOLOGY

        = 0x063E
          The Indoor Lab, LLC

        = 0x063D
          Xradio Technology Co.,Ltd.

        = 0x063C
          Contec Medical Systems Co., Ltd.

        = 0x063B
          Kromek Group Plc

        = 0x063A
          Prolojik Limited

        = 0x0639
          Shenzhen Minew Technologies Co., Ltd.

        = 0x0638
          LX SOLUTIONS PTY LIMITED

        = 0x0637
          GiP Innovation Tools GmbH

        = 0x0636
          ELECTRONICA INTEGRAL DE SONIDO S.A.

        = 0x0635
          Crookwood

        = 0x0634
          Fanstel Corp

        = 0x0633
          Wangi Lai PLT

        = 0x0632
          Hugo Muller GmbH & Co KG

        = 0x0631
          Fortiori Design LLC

        = 0x0630
          Asthrea D.O.O.

        = 0x062F
          ONKYO Corporation

        = 0x062E
          Procept

        = 0x062D
          Vossloh-Schwabe Deutschland GmbH

        = 0x062C
          ASPion GmbH

        = 0x062B
          MinebeaMitsumi Inc.

        = 0x062A
          Lunatico Astronomia SL

        = 0x0629
          PHONEPE PVT LTD

        = 0x0628
          Ensto Oy

        = 0x0627
          WEG S.A.

        = 0x0626
          Amplifico

        = 0x0625
          Square Panda, Inc.

        = 0x0624
          Biovotion AG

        = 0x0623
          Philadelphia Scientific (U.K.) Limited

        = 0x0622
          Beam Labs, LLC

        = 0x0621
          Noordung d.o.o.

        = 0x0620
          Forciot Oy

        = 0x061F
          Phrame Inc.

        = 0x061E
          Diamond Kinetics, Inc.

        = 0x061D
          SENS Innovation ApS

        = 0x061C
          Univations Limited

        = 0x061B
          silex technology, inc.

        = 0x061A
          R.W. Beckett Corporation

        = 0x0619
          Six Guys Labs, s.r.o.

        = 0x0618
          Audio-Technica Corporation

        = 0x0617
          WIZCONNECTED COMPANY LIMITED

        = 0x0616
          OS42 UG (haftungsbeschraenkt)

        = 0x0615
          INTER ACTION Corporation

        = 0x0614
          OnAsset Intelligence, Inc.

        = 0x0613
          Hans Dinslage GmbH

        = 0x0612
          Playfinity AS

        = 0x0611
          Beurer GmbH

        = 0x0610
          ADH GUARDIAN USA LLC

        = 0x060F
          Signify Netherlands B.V.

        = 0x060E
          Blueair AB

        = 0x060D
          TDK Corporation

        = 0x060C
          Vuzix Corporation

        = 0x060B
          Triax Technologies Inc

        = 0x060A
          IQAir AG

        = 0x0609
          BUCHI Labortechnik AG

        = 0x0608
          KeySafe-Cloud

        = 0x0607
          Rookery Technology Ltd

        = 0x0606
          John Deere

        = 0x0605
          FMW electronic Futterer u. Maier-Wolf OHG

        = 0x0604
          Cell2Jack LLC

        = 0x0603
          Fourth Evolution Inc

        = 0x0602
          Geberit International AG

        = 0x0601
          Schrader Electronics

        = 0x0600
          iRobot Corporation

        = 0x05FF
          Wellnomics Ltd

        = 0x05FE
          Niko nv

        = 0x05FD
          Innoseis

        = 0x05FC
          Masbando GmbH

        = 0x05FB
          Arblet Inc.

        = 0x05FA
          Konami Sports Life Co., Ltd.

        = 0x05F9
          Hagleitner Hygiene International GmbH

        = 0x05F8
          Anki Inc.

        = 0x05F7
          TRACMO, INC.

        = 0x05F6
          DPTechnics

        = 0x05F5
          GS TAG

        = 0x05F4
          Clearity, LLC

        = 0x05F3
          SeeScan

        = 0x05F2
          Try and E CO.,LTD.

        = 0x05F1
          The Linux Foundation

        = 0x05F0
          beken

        = 0x05EF
          SIKOM AS

        = 0x05EE
          Wristcam Inc.

        = 0x05ED
          Fuji Xerox Co., Ltd

        = 0x05EC
          Gycom Svenska AB

        = 0x05EB
          Bayerische Motoren Werke AG

        = 0x05EA
          ACS-Control-System GmbH

        = 0x05E9
          iconmobile GmbH

        = 0x05E8
          COWBOY

        = 0x05E7
          PressurePro

        = 0x05E6
          Motion Instruments Inc.

        = 0x05E5
          INEO ENERGY& SYSTEMS

        = 0x05E4
          Taiyo Yuden Co., Ltd

        = 0x05E3
          Elemental Machines, Inc.

        = 0x05E2
          stAPPtronics GmbH

        = 0x05E1
          Human, Incorporated

        = 0x05E0
          Viper Design LLC

        = 0x05DF
          VIRTUALCLINIC.DIRECT LIMITED

        = 0x05DE
          QT Medical INC.

        = 0x05DD
          essentim GmbH

        = 0x05DC
          Petronics Inc.

        = 0x05DB
          Avid Identification Systems, Inc.

        = 0x05DA
          Applied Neural Research Corp

        = 0x05D9
          Toyo Electronics Corporation

        = 0x05D8
          Farm Jenny LLC

        = 0x05D7
          modum.io AG

        = 0x05D6
          Zhuhai Jieli technology Co.,Ltd

        = 0x05D5
          TEGAM, Inc.

        = 0x05D4
          LAMPLIGHT Co., Ltd.

        = 0x05D3
          Acurable Limited

        = 0x05D2
          frogblue TECHNOLOGY GmbH

        = 0x05D1
          Lindab AB

        = 0x05D0
          Anova Applied Electronics

        = 0x05CF
          Biowatch SA

        = 0x05CE
          V-ZUG Ltd

        = 0x05CD
          RJ Brands LLC

        = 0x05CC
          WATTS ELECTRONICS

        = 0x05CB
          LucentWear LLC

        = 0x05CA
          MHL Custom Inc

        = 0x05C9
          TBS Electronics B.V.

        = 0x05C8
          SOMFY SAS

        = 0x05C7
          Lippert Components, INC

        = 0x05C6
          Smart Animal Training Systems, LLC

        = 0x05C5
          SELVE GmbH & Co. KG

        = 0x05C4
          Codecoup sp. z o.o. sp. k.

        = 0x05C3
          Runtime, Inc.

        = 0x05C2
          Grote Industries

        = 0x05C1
          P.I.Engineering

        = 0x05C0
          Nalu Medical, Inc.

        = 0x05BF
          Real-World-Systems Corporation

        = 0x05BE
          RFID Global by Softwork SrL

        = 0x05BD
          ULC Robotics Inc.

        = 0x05BC
          Leviton Mfg. Co., Inc.

        = 0x05BB
          Oxford Metrics plc

        = 0x05BA
          igloohome

        = 0x05B9
          Suzhou Pairlink Network Technology

        = 0x05B8
          Ambystoma Labs Inc.

        = 0x05B7
          Beijing Pinecone Electronics Co.,Ltd.

        = 0x05B6
          Elecs Industry Co.,Ltd.

        = 0x05B5
          verisilicon

        = 0x05B4
          White Horse Scientific ltd

        = 0x05B3
          Parabit Systems, Inc.

        = 0x05B2
          CAREL INDUSTRIES S.P.A.

        = 0x05B1
          Medallion Instrumentation Systems

        = 0x05B0
          NewTec GmbH

        = 0x05AF
          OV LOOP, INC.

        = 0x05AE
          CARMATE MFG.CO.,LTD

        = 0x05AD
          INIA

        = 0x05AC
          GoerTek Dynaudio Co., Ltd.

        = 0x05AB
          Nofence AS

        = 0x05AA
          Tramex Limited

        = 0x05A9
          Monidor

        = 0x05A8
          Tom Allebrandi Consulting

        = 0x05A7
          Sonos Inc

        = 0x05A6
          Telecon Mobile Limited

        = 0x05A5
          Kiiroo BV

        = 0x05A4
          O. E. M. Controls, Inc.

        = 0x05A3
          Axiomware Systems Incorporated

        = 0x05A2
          ADHERIUM(NZ) LIMITED

        = 0x05A1
          Shanghai Xiaoyi Technology Co.,Ltd.

        = 0x05A0
          RCP Software Oy

        = 0x059F
          Fisher & Paykel Healthcare

        = 0x059E
          Polycom, Inc.

        = 0x059D
          Tandem Diabetes Care

        = 0x059C
          Macrogiga Electronics

        = 0x059B
          Dataflow Systems Limited

        = 0x059A
          Teledyne Lecroy, Inc.

        = 0x0599
          Lazlo326, LLC.

        = 0x0598
          rapitag GmbH

        = 0x0597
          RadioPulse Inc

        = 0x0596
          My Smart Blinds

        = 0x0595
          Inor Process AB

        = 0x0594
          Kohler Company

        = 0x0593
          Spaulding Clinical Research

        = 0x0592
          IZITHERM

        = 0x0591
          Viasat Group S.p.A.

        = 0x0590
          Pur3 Ltd

        = 0x058F
          HENDON SEMICONDUCTORS PTY LTD

        = 0x058E
          Meta Platforms Technologies, LLC

        = 0x058D
          Jungheinrich Aktiengesellschaft

        = 0x058C
          Fracarro Radioindustrie SRL

        = 0x058B
          Maxim Integrated Products

        = 0x058A
          START TODAY CO.,LTD.

        = 0x0589
          Star Technologies

        = 0x0588
          ALT-TEKNIK LLC

        = 0x0587
          Derichs GmbH

        = 0x0586
          LEGRAND

        = 0x0585
          Hearing Lab Technology

        = 0x0584
          Gira Giersiepen GmbH & Co. KG

        = 0x0583
          Code Blue Communications

        = 0x0582
          Breakwall Analytics, LLC

        = 0x0581
          LYS TECHNOLOGIES LTD

        = 0x0580
          ARANZ Medical Limited

        = 0x057F
          Scuf Gaming International, LLC

        = 0x057E
          Beco, Inc

        = 0x057D
          Instinct Performance

        = 0x057C
          Toor Technologies LLC

        = 0x057B
          Duracell U.S. Operations Inc.

        = 0x057A
          OMNI Remotes

        = 0x0579
          Ensemble Tech Private Limited

        = 0x0578
          Wellington Drive Technologies Ltd

        = 0x0577
          True Wearables, Inc.

        = 0x0576
          Globalstar, Inc.

        = 0x0575
          Integral Memroy Plc

        = 0x0574
          AFFORDABLE ELECTRONICS INC

        = 0x0573
          Lighting Science Group Corp.

        = 0x0572
          AntTail.com

        = 0x0571
          PSIKICK, INC.

        = 0x0570
          Consumer Sleep Solutions LLC

        = 0x056F
          BikeFinder AS

        = 0x056E
          VIZPIN INC.

        = 0x056D
          Redmond Industrial Group LLC

        = 0x056C
          Long Range Systems, LLC

        = 0x056B
          Rion Co., Ltd.

        = 0x056A
          Flipnavi Co.,Ltd.

        = 0x0569
          Audionics System, INC.

        = 0x0568
          Bodyport Inc.

        = 0x0567
          Xiamen Everesports Goods Co., Ltd

        = 0x0566
          CORE TRANSPORT TECHNOLOGIES NZ LIMITED

        = 0x0565
          Beijing Smartspace Technologies Inc.

        = 0x0564
          Beghelli Spa

        = 0x0563
          Steinel Vertrieb GmbH

        = 0x0562
          Thalmic Labs Inc.

        = 0x0561
          Finder S.p.A.

        = 0x0560
          Sarita CareTech APS

        = 0x055F
          PROTECH S.A.S. DI GIRARDI ANDREA & C.

        = 0x055E
          Hekatron Vertriebs GmbH

        = 0x055D
          Valve Corporation

        = 0x055C
          Lely

        = 0x055B
          FRANKLIN TECHNOLOGY INC

        = 0x055A
          CANDY HOUSE, Inc.

        = 0x0559
          Newcon Optik

        = 0x0558
          benegear, inc.

        = 0x0557
          Arwin Technology Limited

        = 0x0556
          Otodynamics Ltd

        = 0x0555
          KROHNE Messtechnik GmbH

        = 0x0554
          National Instruments

        = 0x0553
          Nintendo Co., Ltd.

        = 0x0552
          Avempace SARL

        = 0x0551
          Sylero

        = 0x0550
          Versa Networks, Inc.

        = 0x054F
          Sinnoz

        = 0x054E
          FORTRONIK storitve d.o.o.

        = 0x054D
          Sensome

        = 0x054C
          Carefree Scott Fetzer Co Inc

        = 0x054B
          Advanced Electronic Designs, Inc.

        = 0x054A
          Linough Inc.

        = 0x0549
          Smart Technologies and Investment Limited

        = 0x0548
          Knick Elektronische Messgeraete GmbH & Co. KG

        = 0x0547
          LOGICDATA Electronic & Software Entwicklungs GmbH

        = 0x0546
          Apexar Technologies S.A.

        = 0x0545
          Candy Hoover Group s.r.l

        = 0x0544
          OrthoSensor, Inc.

        = 0x0543
          MIWA LOCK CO.,Ltd

        = 0x0542
          Mist Systems, Inc.

        = 0x0541
          Sharknet srl

        = 0x0540
          SilverPlus, Inc

        = 0x053F
          Silergy Corp

        = 0x053E
          CLIM8 LIMITED

        = 0x053D
          TESA SA

        = 0x053C
          Screenovate Technologies Ltd

        = 0x053B
          prodigy

        = 0x053A
          Savitech Corp.,

        = 0x0539
          OPPLE Lighting Co., Ltd

        = 0x0538
          Medela AG

        = 0x0537
          MetaLogics Corporation

        = 0x0536
          ZTR Control Systems LLC

        = 0x0535
          Smart Component Technologies Limited

        = 0x0534
          Frontiergadget, Inc.

        = 0x0533
          Nura Operations Pty Ltd

        = 0x0532
          CRESCO Wireless, Inc.

        = 0x0531
          D&M Holdings Inc.

        = 0x0530
          Adolene, Inc.

        = 0x052F
          Center ID Corp.

        = 0x052E
          LEDVANCE GmbH

        = 0x052D
          EXFO, Inc.

        = 0x052C
          Geosatis SA

        = 0x052B
          Novartis AG

        = 0x052A
          Keynes Controls Ltd

        = 0x0529
          Lumen UAB

        = 0x0528
          Lunera Lighting Inc.

        = 0x0527
          Albrecht JUNG

        = 0x0526
          Honeywell International Inc.

        = 0x0525
          HONGKONG NANO IC TECHNOLOGIES  CO., LIMITED

        = 0x0524
          Hangzhou iMagic Technology Co., Ltd

        = 0x0523
          MTG Co., Ltd.

        = 0x0522
          NS Tech, Inc.

        = 0x0521
          IAI Corporation

        = 0x0520
          Target Corporation

        = 0x051F
          Setec Pty Ltd

        = 0x051E
          Detect Blue Limited

        = 0x051D
          OFF Line Co., Ltd.

        = 0x051C
          EDPS

        = 0x051B
          Angee Technologies Ltd.

        = 0x051A
          Leica Camera AG

        = 0x0519
          Tyto Life LLC

        = 0x0518
          MAMORIO.inc

        = 0x0517
          Amtronic Sverige AB

        = 0x0516
          Footmarks

        = 0x0515
          RB Controls Co., Ltd.

        = 0x0514
          FIBRO GmbH

        = 0x0513
          9974091 Canada Inc.

        = 0x0512
          Soprod SA

        = 0x0511
          Brookfield Equinox LLC

        = 0x0510
          UNI-ELECTRONICS, INC.

        = 0x050F
          Foundation Engineering LLC

        = 0x050E
          Yichip Microelectronics (Hangzhou) Co.,Ltd.

        = 0x050D
          TRSystems GmbH

        = 0x050C
          OSRAM GmbH

        = 0x050B
          Vibrissa Inc.

        = 0x050A
          Shake-on B.V.

        = 0x0509
          Garage Smart, Inc.

        = 0x0508
          Axes System sp. z o. o.

        = 0x0507
          Yellowcog

        = 0x0506
          Hager

        = 0x0505
          InPlay, Inc.

        = 0x0504
          PHYPLUS Inc

        = 0x0503
          Locoroll, Inc

        = 0x0502
          Specifi-Kali LLC

        = 0x0501
          Polaris IND

        = 0x0500
          Wiliot LTD.

        = 0x04FF
          Microsemi Corporation

        = 0x04FE
          Woosim Systems Inc.

        = 0x04FD
          Tapkey GmbH

        = 0x04FC
          SwingLync L. L. C.

        = 0x04FB
          Benchmark Drives GmbH & Co. KG

        = 0x04FA
          Androtec GmbH

        = 0x04F9
          Interactio

        = 0x04F8
          Convergence Systems Limited

        = 0x04F7
          Shenzhen Goodix Technology Co., Ltd

        = 0x04F6
          McLear Limited

        = 0x04F5
          Pirelli Tyre S.P.A.

        = 0x04F4
          ZanCompute Inc.

        = 0x04F3
          Cerevast Medical

        = 0x04F2
          InDreamer Techsol Private Limited

        = 0x04F1
          Theben AG

        = 0x04F0
          Kosi Limited

        = 0x04EF
          DaisyWorks, Inc

        = 0x04EE
          Auxivia

        = 0x04ED
          R9 Technology, Inc.

        = 0x04EC
          Motorola Solutions

        = 0x04EB
          Bird Home Automation GmbH

        = 0x04EA
          Pacific Bioscience Laboratories, Inc

        = 0x04E9
          Busch Jaeger Elektro GmbH

        = 0x04E8
          STABILO International

        = 0x04E7
          REHABTRONICS INC.

        = 0x04E6
          Smart Solution Technology, Inc.

        = 0x04E5
          Avack Oy

        = 0x04E4
          Woodenshark

        = 0x04E3
          Under Armour

        = 0x04E2
          EllieGrid

        = 0x04E1
          REACTEC LIMITED

        = 0x04E0
          Guardtec, Inc.

        = 0x04DF
          Emerson Electric Co.

        = 0x04DE
          Lutron Electronics Co., Inc.

        = 0x04DD
          4MOD Technology

        = 0x04DC
          IOTTIVE (OPC) PRIVATE LIMITED

        = 0x04DB
          Engineered Audio, LLC.

        = 0x04DA
          Franceschi Marina snc

        = 0x04D9
          RM Acquisition LLC

        = 0x04D8
          FUJIFILM Corporation

        = 0x04D7
          Blincam, Inc.

        = 0x04D6
          LUGLOC LLC

        = 0x04D5
          Gooee Limited

        = 0x04D4
          5th Element Ltd

        = 0x04D3
          Queercon, Inc

        = 0x04D2
          Anloq Technologies Inc.

        = 0x04D1
          KTS GmbH

        = 0x04D0
          Olympus Corporation

        = 0x04CF
          DOM Sicherheitstechnik GmbH & Co. KG

        = 0x04CE
          GOOOLED S.R.L.

        = 0x04CD
          Safetech Products LLC

        = 0x04CC
          Enflux Inc.

        = 0x04CB
          Novo Nordisk A/S

        = 0x04CA
          Steiner-Optik GmbH

        = 0x04C9
          Thornwave Labs Inc

        = 0x04C8
          Shanghai Flyco Electrical Appliance Co., Ltd.

        = 0x04C7
          Svantek Sp. z o.o.

        = 0x04C6
          Insta GmbH

        = 0x04C5
          Seibert Williams Glass, LLC

        = 0x04C4
          TeAM Hutchins AB

        = 0x04C3
          Mantracourt Electronics Limited

        = 0x04C2
          Dmet Products Corp.

        = 0x04C1
          Sospitas, s.r.o.

        = 0x04C0
          Statsports International

        = 0x04BF
          VIT Initiative, LLC

        = 0x04BE
          Averos FZCO

        = 0x04BD
          AlbynMedical

        = 0x04BC
          Draegerwerk AG & Co. KGaA

        = 0x04BB
          Neatebox Ltd

        = 0x04BA
          Crestron Electronics, Inc.

        = 0x04B9
          CSR Building Products Limited

        = 0x04B8
          Soraa Inc.

        = 0x04B7
          Analog Devices, Inc.

        = 0x04B6
          Diagnoptics Technologies

        = 0x04B5
          Swiftronix AB

        = 0x04B4
          Inuheat Group AB

        = 0x04B3
          mobike (Hong Kong) Limited

        = 0x04B2
          The Shadow on the Moon

        = 0x04B1
          Kartographers Technologies Pvt. Ltd.

        = 0x04B0
          Weba Sport und Med. Artikel GmbH

        = 0x04AF
          BIOROWER Handelsagentur GmbH

        = 0x04AE
          ERM Electronic Systems LTD

        = 0x04AD
          Shure Inc

        = 0x04AC
          Undagrid B.V.

        = 0x04AB
          Harbortronics, Inc.

        = 0x04AA
          LINKIO SAS

        = 0x04A9
          DISCOVERY SOUND TECHNOLOGY, LLC

        = 0x04A8
          BioTex, Inc.

        = 0x04A7
          Dallas Logic Corporation

        = 0x04A6
          Vinetech Co., Ltd

        = 0x04A5
          Guangzhou FiiO Electronics Technology Co.,Ltd

        = 0x04A4
          Herbert Waldmann GmbH & Co. KG

        = 0x04A3
          GT-tronics HK Ltd

        = 0x04A2
          ovrEngineered, LLC

        = 0x04A1
          PNI Sensor Corporation

        = 0x04A0
          Vypin, LLC

        = 0x049F
          Popper Pay AB

        = 0x049E
          AND!XOR LLC

        = 0x049D
          Uhlmann & Zacher GmbH

        = 0x049C
          DyOcean

        = 0x049B
          nVisti, LLC

        = 0x049A
          Situne AS

        = 0x0499
          Ruuvi Innovations Ltd.

        = 0x0498
          METER Group, Inc. USA

        = 0x0497
          Cochlear Limited

        = 0x0496
          Polymorphic Labs LLC

        = 0x0495
          LMT Mercer Group, Inc

        = 0x0494
          SENNHEISER electronic GmbH & Co. KG

        = 0x0493
          Lynxemi Pte Ltd

        = 0x0492
          ADC Technology, Inc.

        = 0x0491
          SOREX - Wireless Solutions GmbH

        = 0x0490
          Matting AB

        = 0x048F
          BlueKitchen GmbH

        = 0x048E
          Companion Medical, Inc.

        = 0x048D
          S-Labs Sp. z o.o.

        = 0x048C
          Vectronix AG

        = 0x048B
          CP Electronics Limited

        = 0x048A
          Taelek Oy

        = 0x0489
          Igarashi Engineering

        = 0x0488
          Automotive Data Solutions Inc

        = 0x0487
          Centrica Connected Home

        = 0x0486
          DEV TECNOLOGIA INDUSTRIA, COMERCIO E MANUTENCAO DE EQUIPAMENTOS LTDA. - ME

        = 0x0485
          SKIDATA AG

        = 0x0484
          Revol Technologies Inc

        = 0x0483
          Multi Care Systems B.V.

        = 0x0482
          POS Tuning Udo Vosshenrich GmbH & Co. KG

        = 0x0481
          Quintrax Limited

        = 0x0480
          Dynometrics Inc.

        = 0x047F
          Pro-Mark, Inc.

        = 0x047E
          OurHub Dev IvS

        = 0x047D
          Occly LLC

        = 0x047C
          POWERMAT LTD

        = 0x047B
          MIYOSHI ELECTRONICS CORPORATION

        = 0x047A
          Sinosun Technology Co., Ltd.

        = 0x0479
          mywerk system GmbH

        = 0x0478
          FarSite Communications Limited

        = 0x0477
          Blue Spark Technologies

        = 0x0476
          Oxstren Wearable Technologies Private Limited

        = 0x0475
          Icom inc.

        = 0x0474
          iApartment co., ltd.

        = 0x0473
          Steelcase, Inc.

        = 0x0472
          Control-J Pty Ltd

        = 0x0471
          TiVo Corp

        = 0x0470
          iDesign s.r.l.

        = 0x046F
          Develco Products A/S

        = 0x046E
          Pambor Ltd.

        = 0x046D
          BEGA Gantenbrink-Leuchten KG

        = 0x046C
          Qingdao Realtime Technology Co., Ltd.

        = 0x046B
          PMD Solutions

        = 0x046A
          INSIGMA INC.

        = 0x0469
          Palago AB

        = 0x0468
          Kynesim Ltd

        = 0x0467
          Codenex Oy

        = 0x0466
          CycleLabs Solutions inc.

        = 0x0465
          International Forte Group LLC

        = 0x0464
          Bellman & Symfon

        = 0x0463
          Fathom Systems Inc.

        = 0x0462
          Bonsai Systems GmbH

        = 0x0461
          vhf elektronik GmbH

        = 0x0460
          Kolibree

        = 0x045F
          Real Time Automation, Inc.

        = 0x045E
          Nuviz, Inc.

        = 0x045D
          Boston Scientific Corporation

        = 0x045C
          Delta T Corporation

        = 0x045B
          SPACEEK LTD

        = 0x045A
          2048450 Ontario Inc

        = 0x0459
          Lumenetix, Inc

        = 0x0458
          Mini Solution Co., Ltd.

        = 0x0457
          RF INNOVATION

        = 0x0456
          Nemik Consulting Inc

        = 0x0455
          Atomation

        = 0x0454
          Sphinx Electronics GmbH & Co KG

        = 0x0453
          Qorvo Utrecht B.V.

        = 0x0452
          Svep Design Center AB

        = 0x0451
          Tunstall Nordic AB

        = 0x0450
          Teenage Engineering AB

        = 0x044F
          TTS Tooltechnic Systems AG & Co. KG

        = 0x044E
          Xtrava Inc.

        = 0x044D
          VEGA Grieshaber KG

        = 0x044C
          LifeStyle Lock, LLC

        = 0x044B
          Nain Inc.

        = 0x044A
          SHIMANO INC.

        = 0x0449
          1UP USA.com llc

        = 0x0448
          Grand Centrix GmbH

        = 0x0447
          Fabtronics Australia Pty Ltd

        = 0x0446
          NETGEAR, Inc.

        = 0x0445
          Kobian Canada Inc.

        = 0x0444
          Metanate Limited

        = 0x0443
          Tucker International LLC

        = 0x0442
          SECOM CO., LTD.

        = 0x0441
          iProtoXi Oy

        = 0x0440
          Valencell, Inc.

        = 0x043F
          Tentacle Sync GmbH

        = 0x043E
          Thermomedics, Inc.

        = 0x043D
          Coiler Corporation

        = 0x043C
          DeLaval

        = 0x043B
          Appside co., ltd.

        = 0x043A
          Nuheara Limited

        = 0x0439
          Radiance Technologies

        = 0x0438
          Helvar Ltd

        = 0x0437
          eBest IOT Inc.

        = 0x0436
          Drayson Technologies (Europe) Limited

        = 0x0435
          Blocks Wearables Ltd.

        = 0x0434
          Hatch Baby, Inc.

        = 0x0433
          Pillsy Inc.

        = 0x0432
          Silk Labs, Inc.

        = 0x0431
          Alticor Inc.

        = 0x0430
          SnapStyk Inc.

        = 0x042F
          Danfoss A/S

        = 0x042E
          MemCachier Inc.

        = 0x042D
          Meshtech AS

        = 0x042C
          Ticto N.V.

        = 0x042B
          iMicroMed Incorporated

        = 0x042A
          BD Medical

        = 0x0429
          Prolon Inc.

        = 0x0428
          SmallLoop, LLC

        = 0x0427
          Focus fleet and fuel management inc

        = 0x0426
          Husqvarna AB

        = 0x0425
          Unify Software and Solutions GmbH & Co. KG

        = 0x0424
          Trainesense Ltd.

        = 0x0423
          Chargifi Limited

        = 0x0422
          DELSEY SA

        = 0x0421
          Backbone Labs, Inc.

        = 0x0420
          TecBakery GmbH

        = 0x041F
          Kopin Corporation

        = 0x041E
          Dell Computer Corporation

        = 0x041D
          Benning Elektrotechnik und Elektronik GmbH & Co. KG

        = 0x041C
          WaterGuru, Inc.

        = 0x041B
          OrthoAccel Technologies

        = 0x041A
          Friday Labs Limited

        = 0x0419
          Novalogy LTD

        = 0x0417
          Fatigue Science

        = 0x0416
          SODA GmbH

        = 0x0415
          Uber Technologies Inc

        = 0x0414
          Lightning Protection International Pty Ltd

        = 0x0413
          Wireless Cables Inc

        = 0x0412
          SEFAM

        = 0x0411
          Luidia Inc

        = 0x0410
          Fender Musical Instruments

        = 0x040F
          CO-AX Technology, Inc.

        = 0x040E
          SKF (U.K.) Limited

        = 0x040D
          NorthStar Battery Company, LLC

        = 0x040C
          Senix Corporation

        = 0x040B
          Jana Care Inc.

        = 0x040A
          ZF OPENMATICS s.r.o.

        = 0x0409
          RYSE INC.

        = 0x0408
          ToGetHome Inc.

        = 0x0407
          Swiss Audio SA

        = 0x0406
          Airtago

        = 0x0405
          Vertex International, Inc.

        = 0x0404
          Authomate Inc

        = 0x0403
          Gantner Electronic GmbH

        = 0x0402
          Sears Holdings Corporation

        = 0x0401
          Relations Inc.

        = 0x0400
          i-developer IT Beratung UG

        = 0x03FF
          Withings

        = 0x03FE
          Littelfuse

        = 0x03FD
          Trimble Inc.

        = 0x03FC
          Kimberly-Clark

        = 0x03FB
          Nox Medical

        = 0x03FA
          Vyassoft Technologies Inc

        = 0x03F9
          Becon Technologies Co.,Ltd.

        = 0x03F8
          Rockford Corp.

        = 0x03F7
          Owl Labs Inc.

        = 0x03F6
          Iton Technology Corp.

        = 0x03F5
          WHERE, Inc.

        = 0x03F4
          PAL Technologies Ltd

        = 0x03F3
          Flowscape AB

        = 0x03F2
          WindowMaster A/S

        = 0x03F1
          Hestan Smart Cooking Inc.

        = 0x03F0
          CLINK

        = 0x03EF
          foolography GmbH

        = 0x03EE
          CUBE TECHNOLOGIES

        = 0x03ED
          BASIC MICRO.COM,INC.

        = 0x03EC
          Jigowatts Inc.

        = 0x03EB
          Ozo Edu, Inc.

        = 0x03EA
          Hello Inc.

        = 0x03E9
          SHENZHEN LEMONJOY TECHNOLOGY CO., LTD.

        = 0x03E8
          Reiner Kartengeraete GmbH & Co. KG.

        = 0x03E7
          TRUE Fitness Technology

        = 0x03E6
          IoT Instruments Oy

        = 0x03E5
          ffly4u

        = 0x03E4
          Chip-ing AG

        = 0x03E3
          Qualcomm Life Inc

        = 0x03E2
          Sensoan Oy

        = 0x03E1
          SPD Development Company Ltd

        = 0x03E0
          Actions (Zhuhai) Technology Co., Limited

        = 0x03DF
          Grob Technologies, LLC

        = 0x03DE
          Nathan Rhoades LLC

        = 0x03DD
          Andreas Stihl AG & Co. KG

        = 0x03DC
          Nima Labs

        = 0x03DB
          Instabeat, Inc

        = 0x03DA
          EnOcean GmbH

        = 0x03D9
          3IWare Co., Ltd.

        = 0x03D8
          Zen-Me Labs Ltd

        = 0x03D7
          FINSECUR

        = 0x03D6
          Yota Devices LTD

        = 0x03D5
          Wyzelink Systems Inc.

        = 0x03D4
          PEG PEREGO SPA

        = 0x03D3
          Sigma Connectivity AB

        = 0x03D2
          IOT Pot India Private Limited

        = 0x03D1
          Density Inc.

        = 0x03D0
          Watteam Ltd

        = 0x03CF
          MIRA, Inc.

        = 0x03CE
          CONTRINEX S.A.

        = 0x03CD
          Wynd Technologies, Inc.

        = 0x03CC
          Vonkil Technologies Ltd

        = 0x03CB
          SYSDEV Srl

        = 0x03CA
          In2things Automation Pvt. Ltd.

        = 0x03C9
          Gallagher Group

        = 0x03C8
          Avvel International

        = 0x03C7
          Structural Health Systems, Inc.

        = 0x03C6
          Intricon

        = 0x03C5
          St. Jude Medical, Inc.

        = 0x03C4
          Pico Technology Inc.

        = 0x03C3
          Casambi Technologies Oy

        = 0x03C2
          Snapchat Inc

        = 0x03C1
          Ember Technologies, Inc.

        = 0x03C0
          Arch Systems Inc.

        = 0x03BF
          iLumi Solutions Inc.

        = 0x03BE
          Applied Science, Inc.

        = 0x03BD
          amadas

        = 0x03BC
          ASB Bank Ltd

        = 0x03BB
          Abbott

        = 0x03BA
          Maxscend Microelectronics Company Limited

        = 0x03B9
          FREDERIQUE CONSTANT SA

        = 0x03B8
          A-Safe Limited

        = 0x03B7
          Airbly Inc.

        = 0x03B6
          Mattel

        = 0x03B5
          petPOMM, Inc

        = 0x03B4
          Alpha Nodus, inc.

        = 0x03B3
          Midwest Instruments & Controls

        = 0x03B2
          Propagation Systems Limited

        = 0x03B1
          Otodata Wireless Network Inc.

        = 0x03B0
          VIBRADORM GmbH

        = 0x03AF
          Comm-N-Sense Corp DBA Verigo

        = 0x03AE
          Allswell Inc.

        = 0x03AD
          XiQ

        = 0x03AC
          Smablo LTD

        = 0x03AB
          Meizu Technology Co., Ltd.

        = 0x03AA
          Exon Sp. z o.o.

        = 0x03A9
          THINKERLY SRL

        = 0x03A8
          Esrille Inc.

        = 0x03A7
          AeroScout

        = 0x03A6
          Medela, Inc

        = 0x03A5
          ACE CAD Enterprise Co., Ltd. (ACECAD)

        = 0x03A4
          Token Zero Ltd

        = 0x03A3
          SmartMovt Technology Co., Ltd

        = 0x03A2
          Candura Instruments

        = 0x03A1
          Alpine Labs LLC

        = 0x03A0
          IVT Wireless Limited

        = 0x039F
          Molex Corporation

        = 0x039E
          SchoolBoard Limited

        = 0x039D
          CareView Communications, Inc.

        = 0x039C
          ALE International

        = 0x039B
          South Silicon Valley Microelectronics

        = 0x039A
          NeST

        = 0x0399
          Nikon Corporation

        = 0x0398
          Thetatronics Ltd

        = 0x0397
          LEGO System A/S

        = 0x0396
          BLOKS GmbH

        = 0x0395
          SDATAWAY

        = 0x0394
          Netclearance Systems, Inc.

        = 0x0393
          LAVAZZA S.p.A.

        = 0x0392
          T&D

        = 0x0391
          Thingsquare AB

        = 0x0390
          INFOTECH s.r.o.

        = 0x038F
          Xiaomi Inc.

        = 0x038E
          Crownstone B.V.

        = 0x038D
          Resmed Ltd

        = 0x038C
          Appion Inc.

        = 0x038B
          Noke

        = 0x038A
          Kohler Mira Limited

        = 0x0389
          ActiveBlu Corporation

        = 0x0388
          Kapsch TrafficCom AB

        = 0x0387
          BluStor PMC, Inc.

        = 0x0386
          Aterica Inc.

        = 0x0385
          Embedded Electronic Solutions Ltd. dba e2Solutions

        = 0x0384
          OCOSMOS Co., Ltd.

        = 0x0383
          Kronos Incorporated

        = 0x0382
          Precision Outcomes Ltd

        = 0x0381
          Sharp Corporation

        = 0x0380
          LLC "MEGA-F service"

        = 0x037F
          SociÃ©tÃ© des Produits NestlÃ© S.A.

        = 0x037E
          lulabytes S.L.

        = 0x037D
          MICRODIA Ltd.

        = 0x037C
          Cronologics Corporation

        = 0x037B
          Apption Labs Inc.

        = 0x037A
          Algoria

        = 0x0379
          Shenzhen iMCO Electronic Technology Co.,Ltd

        = 0x0378
          Propeller Health

        = 0x0377
          Plejd AB

        = 0x0376
          Electronic Temperature Instruments Ltd

        = 0x0375
          Expain AS

        = 0x0374
          Holman Industries

        = 0x0373
          AppNearMe Ltd

        = 0x0372
          Nixie Labs, Inc.

        = 0x0371
          ORBCOMM

        = 0x0370
          Wazombi Labs OÃœ

        = 0x036F
          Motiv, Inc.

        = 0x036E
          MOTIVE TECHNOLOGIES, INC.

        = 0x036D
          AirBolt Pty Ltd

        = 0x036C
          Zipcar

        = 0x036B
          BRControls Products BV

        = 0x036A
          SetPoint Medical

        = 0x0369
          littleBits

        = 0x0368
          Metormote AB

        = 0x0367
          Saphe International

        = 0x0366
          BOLTT Sports technologies Private limited

        = 0x0365
          BioMech Sensor LLC

        = 0x0364
          Favero Electronics Srl

        = 0x0363
          FREELAP SA

        = 0x0362
          ON Semiconductor

        = 0x0361
          Wellinks Inc.

        = 0x0360
          Insulet Corporation

        = 0x035F
          Acromag

        = 0x035E
          Naya Health, Inc.

        = 0x035D
          KYS

        = 0x035C
          Eaton Corporation

        = 0x035B
          Matrix Inc.

        = 0x035A
          Phillips-Medisize A/S

        = 0x0359
          Novotec Medical GmbH

        = 0x0358
          MagniWare Ltd.

        = 0x0357
          Polymap Wireless

        = 0x0356
          Spectrum Brands, Inc.

        = 0x0355
          Sigma Designs, Inc.

        = 0x0354
          TOPPAN FORMS CO.,LTD.

        = 0x0353
          Alpha Audiotronics, Inc.

        = 0x0352
          iRiding(Xiamen)Technology Co.,Ltd.

        = 0x0351
          Pieps GmbH

        = 0x0350
          Bitstrata Systems Inc.

        = 0x034F
          Heartland Payment Systems

        = 0x034E
          SafeTrust Inc.

        = 0x034D
          TASER International, Inc.

        = 0x034C
          HM Electronics, Inc.

        = 0x034B
          Libratone A/S

        = 0x034A
          Vaddio

        = 0x0349
          VersaMe

        = 0x0348
          Arioneo

        = 0x0347
          Prevent Biometrics

        = 0x0346
          Acuity Brands Lighting, Inc

        = 0x0345
          Locus Positioning

        = 0x0344
          Whirl Inc

        = 0x0343
          Drekker Development Pty. Ltd.

        = 0x0342
          GERTEC BRASIL LTDA.

        = 0x0341
          Etesian Technologies LLC

        = 0x0340
          Letsense s.r.l.

        = 0x033F
          Automation Components, Inc.

        = 0x033E
          Monitra SA

        = 0x033D
          TPV Technology Limited

        = 0x033C
          Virtuosys

        = 0x033B
          Courtney Thorne Limited

        = 0x033A
          Appception, Inc.

        = 0x0339
          Blue Sky Scientific, LLC

        = 0x0338
          COBI GmbH

        = 0x0337
          AJP2 Holdings, LLC

        = 0x0336
          GISTIC

        = 0x0335
          Enlighted Inc

        = 0x0334
          Airthings ASA

        = 0x0333
          Mul-T-Lock

        = 0x0332
          Electrocompaniet A.S.

        = 0x0331
          3flares Technologies Inc.

        = 0x0330
          North Pole Engineering

        = 0x032F
          OttoQ Inc

        = 0x032E
          indoormap

        = 0x032D
          BM innovations GmbH

        = 0x032C
          NIPPON SMT.CO.,Ltd

        = 0x032B
          ESYLUX

        = 0x032A
          Electronic Design Lab

        = 0x0329
          Eargo, Inc.

        = 0x0328
          Grundfos A/S

        = 0x0327
          Essex Electronics

        = 0x0326
          Healthwear Technologies (Changzhou)Ltd

        = 0x0325
          Amotus Solutions

        = 0x0324
          Astro, Inc.

        = 0x0323
          Rotor Bike Components

        = 0x0322
          Compumedics Limited

        = 0x0321
          Jewelbots

        = 0x0320
          SONO ELECTRONICS. CO., LTD

        = 0x031F
          MetaSystem S.p.A.

        = 0x031E
          Eyefi, Inc.

        = 0x031D
          Enterlab ApS

        = 0x031C
          Lab Sensor Solutions

        = 0x031B
          HQ Inc

        = 0x031A
          Wurth Elektronik eiSos GmbH & Co. KG

        = 0x0319
          Eugster Frismag AG

        = 0x0318
          Aspenta International

        = 0x0317
          CHUO Electronics CO., LTD.

        = 0x0316
          AG Measurematics Pvt. Ltd.

        = 0x0315
          Thermo Fisher Scientific

        = 0x0314
          RIIG AI Sp. z o.o.

        = 0x0313
          DiveNav, Inc.

        = 0x0312
          Ducere Technologies Pvt Ltd

        = 0x0311
          PEEQ DATA

        = 0x0310
          SGL Italia S.r.l.

        = 0x030F
          Shortcut Labs

        = 0x030E
          Deviceworx

        = 0x030D
          Devdata S.r.l.

        = 0x030C
          Hilti AG

        = 0x030B
          Magnitude Lighting Converters

        = 0x030A
          Ellisys

        = 0x0309
          Dolby Labs

        = 0x0308
          Surefire, LLC

        = 0x0307
          FUJI INDUSTRIAL CO.,LTD.

        = 0x0306
          Life Laboratory Inc.

        = 0x0305
          Swipp ApS

        = 0x0304
          Proxy Technologies, Inc.

        = 0x0303
          IACA electronique

        = 0x0302
          Loop Devices, Inc

        = 0x0301
          Giatec Scientific Inc.

        = 0x0300
          World Moto Inc.

        = 0x02FF
          Silicon Laboratories

        = 0x02FE
          Lierda Science & Technology Group Co., Ltd.

        = 0x02FD
          Uwanna, Inc.

        = 0x02FC
          Shanghai Frequen Microelectronics Co., Ltd.

        = 0x02FB
          Clarius Mobile Health Corp.

        = 0x02FA
          CoSTAR TEchnologies

        = 0x02F9
          IMAGINATION TECHNOLOGIES LTD

        = 0x02F8
          Runteq Oy Ltd

        = 0x02F7
          DreamVisions co., Ltd.

        = 0x02F6
          Intemo Technologies

        = 0x02F5
          Indagem Tech LLC

        = 0x02F4
          Vensi, Inc.

        = 0x02F3
          AuthAir, Inc

        = 0x02F2
          GoPro, Inc.

        = 0x02F1
          The Idea Cave, LLC

        = 0x02F0
          Blackrat Software

        = 0x02EF
          SMART-INNOVATION.inc

        = 0x02EE
          Citizen Holdings Co., Ltd.

        = 0x02ED
          HTC Corporation

        = 0x02EC
          Delta Systems, Inc

        = 0x02EB
          Ardic Technology

        = 0x02EA
          Fujitsu Limited

        = 0x02E9
          Sensogram Technologies, Inc.

        = 0x02E8
          American Music Environments

        = 0x02E7
          Connected Yard, Inc.

        = 0x02E6
          Unwire

        = 0x02E5
          Espressif Systems (Shanghai) Co., Ltd.

        = 0x02E4
          Bytestorm Ltd.

        = 0x02E3
          Carmanah Technologies Corp.

        = 0x02E2
          NTT docomo

        = 0x02E1
          Victron Energy BV

        = 0x02E0
          University of Michigan

        = 0x02DF
          Blur Product Development

        = 0x02DE
          Samsung SDS Co., Ltd.

        = 0x02DD
          Flint Rehabilitation Devices, LLC

        = 0x02DC
          DeWalch Technologies, Inc.

        = 0x02DB
          Digi International Inc (R)

        = 0x02DA
          Gilvader

        = 0x02D9
          Fliegl Agrartechnik GmbH

        = 0x02D8
          Neosfar

        = 0x02D7
          NIPPON SYSTEMWARE CO.,LTD.

        = 0x02D6
          Send Solutions

        = 0x02D5
          OMRON Corporation

        = 0x02D4
          Secuyou ApS

        = 0x02D3
          Powercast Corporation

        = 0x02D2
          Afero, Inc.

        = 0x02D1
          Empatica Srl

        = 0x02D0
          3M

        = 0x02CF
          Anima

        = 0x02CE
          Teva Branded Pharmaceutical Products R&D, Inc.

        = 0x02CD
          BMA ergonomics b.v.

        = 0x02CC
          Eijkelkamp Soil & Water

        = 0x02CB
          AINA-Wireless Inc.

        = 0x02CA
          ABOV Semiconductor

        = 0x02C9
          PayRange Inc.

        = 0x02C8
          OneSpan

        = 0x02C7
          Electronics Tomorrow Limited

        = 0x02C6
          Ayatan Sensors

        = 0x02C5
          Lenovo (Singapore) Pte Ltd.

        = 0x02C4
          Wilson Sporting Goods

        = 0x02C3
          Techtronic Power Tools Technology Limited

        = 0x02C2
          Guillemot Corporation

        = 0x02C1
          LINE Corporation

        = 0x02C0
          Dash Robotics

        = 0x02BF
          Redbird Flight Simulations

        = 0x02BE
          Seguro Technology Sp. z o.o.

        = 0x02BD
          Chemtronics

        = 0x02BC
          Genevac Ltd

        = 0x02BB
          Koha.,Co.Ltd

        = 0x02BA
          Swissprime Technologies AG

        = 0x02B9
          Rinnai Corporation

        = 0x02B8
          Chrono Therapeutics

        = 0x02B7
          Oort Technologies LLC

        = 0x02B6
          Schneider Electric

        = 0x02B5
          HANSHIN ELECTRIC RAILWAY CO.,LTD.

        = 0x02B4
          Hyginex, Inc.

        = 0x02B3
          CLABER S.P.A.

        = 0x02B2
          Oura Health Oy

        = 0x02B1
          Raden Inc

        = 0x02B0
          Bestechnic(Shanghai),Ltd

        = 0x02AF
          Technicolor USA Inc.

        = 0x02AE
          WeatherFlow, Inc.

        = 0x02AD
          Rx Networks, Inc.

        = 0x02AC
          RTB Elektronik GmbH & Co. KG

        = 0x02AB
          BBPOS Limited

        = 0x02AA
          Doppler Lab

        = 0x02A9
          Chargelib

        = 0x02A8
          miSport Ltd.

        = 0x02A7
          Illuxtron international B.V.

        = 0x02A6
          Robert Bosch GmbH

        = 0x02A5
          Tendyron Corporation

        = 0x02A4
          Pacific Lock Company

        = 0x02A3
          Itude

        = 0x02A2
          Sera4 Ltd.

        = 0x02A1
          InventureTrack Systems

        = 0x02A0
          Impossible Camera GmbH

        = 0x029F
          Areus Engineering GmbH

        = 0x029E
          Kupson spol. s r.o.

        = 0x029D
          ALOTTAZS LABS, LLC

        = 0x029C
          Blue Sky Scientific, LLC

        = 0x029B
          C2 Development, Inc.

        = 0x029A
          Currant, Inc.

        = 0x0299
          Inexess Technology Simma KG

        = 0x0298
          EISST Ltd

        = 0x0297
          storm power ltd

        = 0x0296
          Petzl

        = 0x0295
          Sivantos GmbH

        = 0x0294
          ELIAS GmbH

        = 0x0293
          Blue Bite

        = 0x0292
          SwiftSensors

        = 0x0291
          CliniCloud Inc

        = 0x0290
          Multibit Oy

        = 0x028F
          Church & Dwight Co., Inc

        = 0x028E
          RF Digital Corp

        = 0x028D
          IF, LLC

        = 0x028C
          NANOLINK APS

        = 0x028B
          Code Gears LTD

        = 0x028A
          Jetro AS

        = 0x0289
          SK Telecom

        = 0x0288
          Willowbank Electronics Ltd

        = 0x0287
          Wally Ventures S.L.

        = 0x0286
          RF Code, Inc.

        = 0x0285
          WOWTech Canada Ltd.

        = 0x0284
          Synapse Electronics

        = 0x0283
          Maven Machines, Inc.

        = 0x0282
          Sonova AG

        = 0x0281
          StoneL

        = 0x0280
          ITEC corporation

        = 0x027F
          ruwido austria gmbh

        = 0x027E
          HabitAware, LLC

        = 0x027D
          HUAWEI Technologies Co., Ltd.

        = 0x027C
          Aseptika Ltd

        = 0x027B
          DEFA AS

        = 0x027A
          Ekomini inc.

        = 0x0279
          steute Schaltgerate GmbH & Co. KG

        = 0x0278
          Johnson Outdoors Inc

        = 0x0277
          bewhere inc

        = 0x0276
          E.G.O. Elektro-Geraetebau GmbH

        = 0x0275
          Geotab

        = 0x0274
          Motsai Research

        = 0x0273
          OCEASOFT

        = 0x0272
          Alps Alpine Co., Ltd.

        = 0x0271
          Animas Corp

        = 0x0270
          LSI ADL Technology

        = 0x026F
          Aptcode Solutions

        = 0x026E
          FLEURBAEY BVBA

        = 0x026D
          Technogym SPA

        = 0x026C
          Domster Tadeusz Szydlowski

        = 0x026B
          DEKA Research & Development Corp.

        = 0x026A
          Gemalto

        = 0x0269
          Torrox GmbH & Co KG

        = 0x0268
          Cerevo

        = 0x0267
          XMI Systems SA

        = 0x0266
          Schawbel Technologies LLC

        = 0x0265
          SMK Corporation

        = 0x0264
          DDS, Inc.

        = 0x0263
          Identiv, Inc.

        = 0x0262
          Glacial Ridge Technologies

        = 0x0261
          SECVRE GmbH

        = 0x0260
          SensaRx

        = 0x025F
          Yardarm Technologies

        = 0x025E
          Fluke Corporation

        = 0x025D
          Lexmark International Inc.

        = 0x025C
          NetEaseï¼ˆHangzhouï¼‰Network co.Ltd.

        = 0x025B
          Five Interactive, LLC dba Zendo

        = 0x025A
          University of Applied Sciences Valais/Haute Ecole Valaisanne

        = 0x0259
          ALTYOR

        = 0x0258
          Devialet SA

        = 0x0257
          AdBabble Local Commerce Inc.

        = 0x0256
          G24 Power Limited

        = 0x0255
          Dai Nippon Printing Co., Ltd.

        = 0x0254
          Playbrush

        = 0x0253
          Xicato Inc.

        = 0x0252
          UKC Technosolution

        = 0x0251
          Lumo Bodytech Inc.

        = 0x0250
          Sapphire Circuits LLC

        = 0x024F
          Schneider SchreibgerÃ¤te GmbH

        = 0x024E
          Microtronics Engineering GmbH

        = 0x024D
          M-Way Solutions GmbH

        = 0x024C
          Blue Clover Devices

        = 0x024B
          Orlan LLC

        = 0x024A
          Uwatec AG

        = 0x0249
          Transcranial Ltd

        = 0x0248
          Parker Hannifin Corp

        = 0x0247
          FiftyThree Inc.

        = 0x0246
          ACKme Networks, Inc.

        = 0x0245
          Endress+Hauser

        = 0x0244
          Iotera Inc

        = 0x0243
          Masimo Corp

        = 0x0242
          16Lab Inc

        = 0x0241
          Bragi GmbH

        = 0x0240
          Argenox Technologies

        = 0x023F
          WaveWare Technologies Inc.

        = 0x023E
          Raven Industries

        = 0x023D
          ViCentra B.V.

        = 0x023C
          Awarepoint

        = 0x023B
          Beijing CarePulse Electronic Technology Co, Ltd

        = 0x023A
          Alatech Tehnology

        = 0x0239
          JIN CO, Ltd

        = 0x0238
          Trakm8 Ltd

        = 0x0237
          MSHeli s.r.l.

        = 0x0236
          Pitpatpet Ltd

        = 0x0235
          Qrio Inc

        = 0x0234
          FengFan (BeiJing) Technology Co, Ltd

        = 0x0233
          Shenzhen SuLong Communication Ltd

        = 0x0232
          x-Senso Solutions Kft

        = 0x0231
          ETA SA

        = 0x0230
          Foster Electric Company, Ltd

        = 0x022F
          Huami (Shanghai) Culture Communication CO., LTD

        = 0x022E
          Siemens AG

        = 0x022D
          Lupine

        = 0x022C
          Pharynks Corporation

        = 0x022B
          Tesla, Inc.

        = 0x022A
          Stamer Musikanlagen GMBH

        = 0x0229
          Muoverti Limited

        = 0x0228
          Twocanoes Labs, LLC

        = 0x0227
          LifeBEAM Technologies

        = 0x0226
          Merlinia A/S

        = 0x0225
          NestlÃ© Nespresso S.A.

        = 0x0224
          Comarch SA

        = 0x0223
          Philip Morris Products S.A.

        = 0x0222
          Praxis Dynamics

        = 0x0221
          Mobiquity Networks Inc

        = 0x0220
          Manus Machina BV

        = 0x021F
          Luster Leaf Products  Inc

        = 0x021E
          Goodnet, Ltd

        = 0x021D
          Edamic

        = 0x021C
          Mobicomm Inc

        = 0x021B
          Cisco Systems, Inc

        = 0x021A
          Blue Speck Labs, LLC

        = 0x0219
          DOTT Limited

        = 0x0218
          Hiotech AB

        = 0x0217
          Tech4home, Lda

        = 0x0216
          MTI Ltd

        = 0x0215
          Lukoton Experience Oy

        = 0x0214
          IK Multimedia Production srl

        = 0x0213
          Wyler AG

        = 0x0212
          Interplan Co., Ltd

        = 0x0211
          Telink Semiconductor Co. Ltd

        = 0x0210
          ikeGPS

        = 0x020F
          Comodule GMBH

        = 0x020E
          Omron Healthcare Co., LTD

        = 0x020D
          Simplo Technology Co., LTD

        = 0x020C
          CoroWare Technologies, Inc

        = 0x020B
          Jaguar Land Rover Limited

        = 0x020A
          Macnica Inc.

        = 0x0209
          InvisionHeart Inc.

        = 0x0208
          LumiGeek LLC

        = 0x0207
          STEMP Inc.

        = 0x0206
          Otter Products, LLC

        = 0x0205
          Smartbotics Inc.

        = 0x0204
          Tapcentive Inc.

        = 0x0203
          Kemppi Oy

        = 0x0202
          Rigado LLC

        = 0x0201
          AR Timing

        = 0x0200
          Verifone Systems Pte Ltd. Taiwan Branch

        = 0x01FF
          Freescale Semiconductor, Inc.

        = 0x01FE
          Radio Systems Corporation

        = 0x01FD
          Kontakt Micro-Location Sp. z o.o.

        = 0x01FC
          Wahoo Fitness, LLC

        = 0x01FB
          Form Lifting, LLC

        = 0x01FA
          Gozio Inc.

        = 0x01F9
          Medtronic Inc.

        = 0x01F8
          Anyka (Guangzhou) Microelectronics Technology Co, LTD

        = 0x01F7
          Gelliner Limited

        = 0x01F6
          DJO Global

        = 0x01F5
          Cool Webthings Limited

        = 0x01F4
          UTC Fire and Security

        = 0x01F3
          The University of Tokyo

        = 0x01F2
          Itron, Inc.

        = 0x01F1
          Zebra Technologies Corporation

        = 0x01F0
          KloudNation

        = 0x01EF
          Fullpower Technologies, Inc.

        = 0x01EE
          Valeo Service

        = 0x01ED
          CuteCircuit LTD

        = 0x01EC
          Spreadtrum Communications Shanghai Ltd

        = 0x01EB
          AutoMap LLC

        = 0x01EA
          Advanced Application Design, Inc.

        = 0x01E9
          Sano, Inc.

        = 0x01E8
          STIR

        = 0x01E7
          IPS Group Inc.

        = 0x01E6
          Technology Solutions (UK) Ltd

        = 0x01E5
          Dynamic Devices Ltd

        = 0x01E4
          Freedom Innovations

        = 0x01E3
          Caterpillar Inc

        = 0x01E2
          Lectronix, Inc.

        = 0x01E1
          Jolla Ltd

        = 0x01E0
          Widex A/S

        = 0x01DF
          Bison Group Ltd.

        = 0x01DE
          Minelab Electronics Pty Limited

        = 0x01DD
          Koninklijke Philips N.V.

        = 0x01DC
          iParking Ltd.

        = 0x01DB
          Innblue Consulting

        = 0x01DA
          Logitech International SA

        = 0x01D9
          Savant Systems LLC

        = 0x01D8
          Code Corporation

        = 0x01D7
          Squadrone Systems Inc.

        = 0x01D6
          G-wearables inc.

        = 0x01D5
          ELAD srl

        = 0x01D4
          Newlab S.r.l.

        = 0x01D3
          Sky Wave Design

        = 0x01D2
          Gill Electronics

        = 0x01D1
          August Home, Inc

        = 0x01D0
          Primus Inter Pares Ltd

        = 0x01CF
          BSH

        = 0x01CE
          HOUWA SYSTEM DESIGN, k.k.

        = 0x01CD
          Chengdu Synwing Technology Ltd

        = 0x01CC
          Sam Labs Ltd.

        = 0x01CB
          Fetch My Pet

        = 0x01CA
          Laerdal Medical AS

        = 0x01C9
          Avi-on

        = 0x01C8
          Poly-Control ApS

        = 0x01C7
          Abiogenix Inc.

        = 0x01C6
          HASWARE Inc.

        = 0x01C5
          Bitcraze AB

        = 0x01C4
          DME Microelectronics

        = 0x01C3
          Bunch

        = 0x01C2
          Transenergooil AG

        = 0x01C1
          BRADATECH Corp.

        = 0x01C0
          pironex GmbH

        = 0x01BF
          Hongkong OnMicro Electronics Limited

        = 0x01BE
          Pulsate Mobile Ltd.

        = 0x01BD
          Syszone Co., Ltd

        = 0x01BC
          SenionLab AB

        = 0x01BB
          Cochlear Bone Anchored Solutions AB

        = 0x01BA
          Stages Cycling LLC

        = 0x01B9
          HANA Micron

        = 0x01B8
          i+D3 S.L.

        = 0x01B7
          General Electric Company

        = 0x01B6
          LM Technologies Ltd

        = 0x01B5
          Nest Labs Inc.

        = 0x01B4
          Trineo Sp. z o.o.

        = 0x01B3
          Nytec, Inc.

        = 0x01B2
          Nymi Inc.

        = 0x01B1
          Netizens Sp. z o.o.

        = 0x01B0
          Star Micronics Co., Ltd.

        = 0x01AF
          Sunrise Micro Devices, Inc.

        = 0x01AE
          Earlens Corporation

        = 0x01AD
          FlightSafety International

        = 0x01AC
          Trividia Health, Inc.

        = 0x01AB
          Meta Platforms, Inc.

        = 0x01AA
          Geophysical Technology Inc.

        = 0x01A9
          Canon Inc.

        = 0x01A8
          Taobao

        = 0x01A7
          ENERGOUS CORPORATION

        = 0x01A6
          Wille Engineering

        = 0x01A5
          Icon Health and Fitness

        = 0x01A4
          MSA Innovation, LLC

        = 0x01A3
          EROAD

        = 0x01A2
          GIGALANE.CO.,LTD

        = 0x01A1
          FIAMM

        = 0x01A0
          Channel Enterprises (HK) Ltd.

        = 0x019F
          Strainstall Ltd

        = 0x019E
          Ceruus

        = 0x019D
          CVS Health

        = 0x019C
          Cokiya Incorporated

        = 0x019B
          CUBETECH s.r.o.

        = 0x019A
          TRON Forum

        = 0x0199
          SALTO SYSTEMS S.L.

        = 0x0198
          VENGIT Korlatolt Felelossegu Tarsasag

        = 0x0197
          WiSilica Inc.

        = 0x0196
          Paxton Access Ltd

        = 0x0195
          Zuli

        = 0x0194
          Acoustic Stream Corporation

        = 0x0193
          Maveric Automation LLC

        = 0x0192
          Cloudleaf, Inc

        = 0x0191
          FDK CORPORATION

        = 0x0190
          Intelletto Technologies Inc.

        = 0x018F
          Fireflies Systems

        = 0x018E
          Fitbit, Inc.

        = 0x018D
          Extron Design Services

        = 0x018C
          Wilo SE

        = 0x018B
          Konica Minolta, Inc.

        = 0x018A
          Able Trend Technology Limited

        = 0x0189
          Physical Enterprises Inc.

        = 0x0188
          Unico RBC

        = 0x0187
          Seraphim Sense Ltd

        = 0x0186
          CORE Lighting Ltd

        = 0x0185
          name: "belapps LLC"

        = 0x0184
          Nectar

        = 0x0183
          Walt Disney

        = 0x0182
          HOP Ubiquitous

        = 0x0181
          Gecko Health Innovations, Inc.

        = 0x0180
          Gigaset Communications GmbH

        = 0x017F
          XTel Wireless ApS

        = 0x017E
          BluDotz Ltd

        = 0x017D
          BatAndCat

        = 0x017C
          Mercedes-Benz Group AG

        = 0x017B
          taskit GmbH

        = 0x017A
          Telemonitor, Inc.

        = 0x0179
          LAPIS Semiconductor Co.,Ltd

        = 0x0178
          CASIO COMPUTER CO., LTD.

        = 0x0177
          I-SYST inc.

        = 0x0176
          SentriLock

        = 0x0175
          Dynamic Controls

        = 0x0174
          Everykey Inc.

        = 0x0173
          Kocomojo, LLC

        = 0x0172
          Connovate Technology Private Limited

        = 0x0171
          Amazon.com Services LLC

        = 0x0170
          Roche Diabetes Care AG

        = 0x016F
          Podo Labs, Inc

        = 0x016E
          Volantic AB

        = 0x016D
          LifeScan Inc

        = 0x016C
          MYSPHERA

        = 0x016B
          Qblinks

        = 0x016A
          Emerson Digital Cold Chain, Inc.

        = 0x0169
          emberlight

        = 0x0168
          Spicebox LLC

        = 0x0167
          Ascensia Diabetes Care US Inc.

        = 0x0166
          MISHIK Pte Ltd

        = 0x0165
          Milwaukee Electric Tools

        = 0x0164
          Qingdao Yeelink Information Technology Co., Ltd.

        = 0x0163
          PCH International

        = 0x0162
          MADSGlobalNZ Ltd.

        = 0x0161
          yikes

        = 0x0160
          AwoX

        = 0x015F
          Timer Cap Co.

        = 0x015E
          Unikey Technologies, Inc.

        = 0x015D
          Estimote, Inc.

        = 0x015C
          Pitius Tec S.L.

        = 0x015B
          Biomedical Research Ltd.

        = 0x015A
          micas AG

        = 0x0159
          ChefSteps, Inc.

        = 0x0158
          Inmite s.r.o.

        = 0x0157
          Anhui Huami Information Technology Co., Ltd.

        = 0x0156
          Accumulate AB

        = 0x0155
          NETATMO

        = 0x0154
          Pebble Technology

        = 0x0153
          ROL Ergo

        = 0x0152
          Vernier Software & Technology

        = 0x0151
          OnBeep

        = 0x0150
          Pioneer Corporation

        = 0x014F
          B&W Group Ltd.

        = 0x014E
          Tangerine, Inc.

        = 0x014D
          HUIZHOU DESAY SV AUTOMOTIVE CO., LTD.

        = 0x014C
          Mesh-Net Ltd

        = 0x014B
          Master Lock

        = 0x014A
          Tivoli Audio, LLC

        = 0x0149
          Perytons Ltd.

        = 0x0148
          Ambimat Electronics

        = 0x0147
          Mighty Cast, Inc.

        = 0x0146
          Ciright

        = 0x0145
          Novatel Wireless

        = 0x0144
          Lintech GmbH

        = 0x0143
          Bkon Connect

        = 0x0142
          Grape Systems Inc.

        = 0x0141
          FedEx Services

        = 0x0140
          Alpine Electronics (China) Co., Ltd

        = 0x013F
          B&B Manufacturing Company

        = 0x013E
          Nod, Inc.

        = 0x013D
          WirelessWERX

        = 0x013C
          Murata Manufacturing Co., Ltd.

        = 0x013B
          Allegion

        = 0x013A
          Tencent Holdings Ltd.

        = 0x0139
          Focus Systems Corporation

        = 0x0138
          NTEO Inc.

        = 0x0137
          Prestigio Plaza Ltd.

        = 0x0136
          Silvair, Inc.

        = 0x0135
          Aireware LLC

        = 0x0134
          Resolution Products, Ltd.

        = 0x0133
          Blue Maestro Limited

        = 0x0132
          MADS Inc

        = 0x0131
          Cypress Semiconductor

        = 0x0130
          Warehouse Innovations

        = 0x012F
          Clarion Co. Inc.

        = 0x012E
          ASSA ABLOY

        = 0x012D
          Sony Corporation

        = 0x012C
          TEMEC Instruments B.V.

        = 0x012B
          SportIQ

        = 0x012A
          Changzhou Yongse Infotech  Co., Ltd.

        = 0x0129
          Nimble Devices Oy

        = 0x0128
          GPSI Group Pty Ltd

        = 0x0127
          Salutica Allied Solutions

        = 0x0126
          Promethean Ltd.

        = 0x0125
          SEAT es

        = 0x0124
          HID Global

        = 0x0123
          Kinsa, Inc

        = 0x0122
          AirTurn, Inc.

        = 0x0121
          Sino Wealth Electronic Ltd.

        = 0x0120
          Porsche AG

        = 0x011F
          Volkswagen AG

        = 0x011E
          Skoda Auto a.s.

        = 0x011D
          Arendi AG

        = 0x011C
          Baidu

        = 0x011B
          Hewlett Packard Enterprise

        = 0x011A
          Qualcomm Labs, Inc.

        = 0x0119
          Wize Technology Co., Ltd.

        = 0x0118
          Radius Networks, Inc.

        = 0x0117
          Wimoto Technologies Inc

        = 0x0116
          10AK Technologies

        = 0x0115
          e.solutions

        = 0x0114
          Xensr

        = 0x0113
          Openbrain Technologies, Co., Ltd.

        = 0x0112
          Visybl Inc.

        = 0x0111
          Steelseries ApS

        = 0x0110
          Nippon Seiki Co., Ltd.

        = 0x010F
          HiSilicon Technologies CO., LIMITED

        = 0x010E
          Audi AG

        = 0x010D
          DENSO TEN Limited

        = 0x010C
          Transducers Direct, LLC

        = 0x010B
          ERi, Inc

        = 0x010A
          Codegate Ltd

        = 0x0109
          Atus BV

        = 0x0108
          Chicony Electronics Co., Ltd.

        = 0x0107
          Demant A/S

        = 0x0106
          Innovative Yachtter Solutions

        = 0x0105
          Ubiquitous Computing Technology Corporation

        = 0x0104
          PLUS Location Systems Pty Ltd

        = 0x0103
          Bang & Olufsen A/S

        = 0x0102
          Keiser Corporation

        = 0x0101
          Fugoo, Inc.

        = 0x0100
          TomTom International BV

        = 0x00FF
          Typo Products, LLC

        = 0x00FE
          Stanley Black and Decker

        = 0x00FD
          ValenceTech Limited

        = 0x00FC
          Delphi Corporation

        = 0x00FB
          KOUKAAM a.s.

        = 0x00FA
          Crystal Alarm AB

        = 0x00F9
          StickNFind

        = 0x00F8
          AceUni Corp., Ltd.

        = 0x00F7
          VSN Technologies, Inc.

        = 0x00F6
          Elcometer Limited

        = 0x00F5
          Smartifier Oy

        = 0x00F4
          Nautilus Inc.

        = 0x00F3
          Kent Displays Inc.

        = 0x00F2
          Morse Project Inc.

        = 0x00F1
          Witron Technology Limited

        = 0x00F0
          PayPal, Inc.

        = 0x00EF
          Bitsplitters GmbH

        = 0x00EE
          Above Average Outcomes, Inc.

        = 0x00ED
          Jolly Logic, LLC

        = 0x00EC
          BioResearch Associates

        = 0x00EB
          Server Technology Inc.

        = 0x00EA
          www.vtracksystems.com

        = 0x00E9
          Vtrack Systems

        = 0x00E8
          ACTS Technologies

        = 0x00E7
          KS Technologies

        = 0x00E6
          Freshtemp

        = 0x00E5
          Eden Software Consultants Ltd.

        = 0x00E4
          L.S. Research, Inc.

        = 0x00E3
          inMusic Brands, Inc

        = 0x00E2
          Semilink Inc

        = 0x00E1
          Danlers Ltd

        = 0x00E0
          Google

        = 0x00DF
          Misfit Wearables Corp

        = 0x00DE
          Muzik LLC

        = 0x00DD
          Hosiden Corporation

        = 0x00DC
          Procter & Gamble

        = 0x00DB
          Snuza (Pty) Ltd

        = 0x00DA
          txtr GmbH

        = 0x00D9
          Voyetra Turtle Beach

        = 0x00D8
          Qualcomm Connected Experiences, Inc.

        = 0x00D7
          Qualcomm Technologies, Inc.

        = 0x00D6
          Timex Group USA, Inc.

        = 0x00D5
          Austco Communication Systems

        = 0x00D4
          Kawantech

        = 0x00D3
          Taixingbang Technology (HK) Co,. LTD.

        = 0x00D2
          Dialog Semiconductor B.V.

        = 0x00D1
          Polar Electro Europe B.V.

        = 0x00D0
          Dexcom, Inc.

        = 0x00CF
          ARCHOS SA

        = 0x00CE
          Eve Systems GmbH

        = 0x00CD
          Microchip Technology Inc.

        = 0x00CC
          Beats Electronics

        = 0x00CB
          Binauric SE

        = 0x00CA
          MC10

        = 0x00C9
          Evluma

        = 0x00C8
          GeLo Inc

        = 0x00C7
          Quuppa Oy.

        = 0x00C6
          Selfly BV

        = 0x00C5
          Onset Computer Corporation

        = 0x00C4
          LG Electronics

        = 0x00C3
          adidas AG

        = 0x00C2
          Geneq Inc.

        = 0x00C1
          Shenzhen Excelsecu Data Technology Co.,Ltd

        = 0x00C0
          AMICCOM Electronics Corporation

        = 0x00BF
          Stalmart Technology Limited

        = 0x00BE
          AAMP of America

        = 0x00BD
          Aplix Corporation

        = 0x00BC
          Ace Sensor Inc

        = 0x00BB
          S-Power Electronics Limited

        = 0x00BA
          Starkey Hearing Technologies

        = 0x00B9
          Johnson Controls, Inc.

        = 0x00B8
          Qualcomm Innovation Center, Inc. (QuIC)

        = 0x00B7
          TreLab Ltd

        = 0x00B6
          Meso international

        = 0x00B5
          Swirl Networks

        = 0x00B4
          BDE Technology Co., Ltd.

        = 0x00B3
          Clarinox Technologies Pty. Ltd.

        = 0x00B2
          Bekey A/S

        = 0x00B1
          Saris Cycling Group, Inc

        = 0x00B0
          Passif Semiconductor Corp

        = 0x00AF
          Cinetix

        = 0x00AE
          Omegawave Oy

        = 0x00AD
          Peter Systemtechnik GmbH

        = 0x00AC
          Green Throttle Games

        = 0x00AB
          Ingenieur-Systemgruppe Zahn GmbH

        = 0x00AA
          CAEN RFID srl

        = 0x00A9
          MARELLI EUROPE S.P.A.

        = 0x00A8
          ARP Devices Limited

        = 0x00A7
          Visteon Corporation

        = 0x00A6
          Panda Ocean Inc.

        = 0x00A5
          OTL Dynamics LLC

        = 0x00A4
          LINAK A/S

        = 0x00A3
          Meta Watch Ltd.

        = 0x00A2
          Vertu Corporation Limited

        = 0x00A1
          SR-Medizinelektronik

        = 0x00A0
          Kensington Computer Products Group

        = 0x009F
          Suunto Oy

        = 0x009E
          Bose Corporation

        = 0x009D
          Geoforce Inc.

        = 0x009C
          Colorfy, Inc.

        = 0x009B
          Jiangsu Toppower Automotive Electronics Co., Ltd.

        = 0x009A
          Alpwise

        = 0x0099
          i.Tech Dynamic Global Distribution Ltd.

        = 0x0098
          zero1.tv GmbH

        = 0x0097
          ConnecteDevice Ltd.

        = 0x0096
          ODM Technology, Inc.

        = 0x0095
          NEC Lighting, Ltd.

        = 0x0094
          Airoha Technology Corp.

        = 0x0093
          Universal Electronics, Inc.

        = 0x0092
          ThinkOptics, Inc.

        = 0x0091
          Advanced PANMOBIL systems GmbH & Co. KG

        = 0x0090
          Funai Electric Co., Ltd.

        = 0x008F
          Telit Wireless Solutions GmbH

        = 0x008E
          Quintic Corp

        = 0x008D
          Zscan Software

        = 0x008C
          Gimbal Inc.

        = 0x008B
          Topcon Positioning Systems, LLC

        = 0x008A
          Jawbone

        = 0x0089
          GN Hearing A/S

        = 0x0088
          Ecotest

        = 0x0087
          Garmin International, Inc.

        = 0x0086
          Equinux AG

        = 0x0085
          BlueRadios, Inc.

        = 0x0084
          Ludus Helsinki Ltd.

        = 0x0083
          TimeKeeping Systems, Inc.

        = 0x0082
          DSEA A/S

        = 0x0081
          WuXi Vimicro

        = 0x0080
          DeLorme Publishing Company, Inc.

        = 0x007F
          Autonet Mobile

        = 0x007E
          Sports Tracking Technologies Ltd.

        = 0x007D
          Seers Technology Co., Ltd.

        = 0x007C
          A & R Cambridge

        = 0x007B
          Hanlynn Technologies

        = 0x007A
          MStar Semiconductor, Inc.

        = 0x0079
          lesswire AG

        = 0x0078
          Nike, Inc.

        = 0x0077
          Laird Connectivity LLC

        = 0x0076
          Creative Technology Ltd.

        = 0x0075
          Samsung Electronics Co. Ltd.

        = 0x0074
          Zomm, LLC

        = 0x0073
          Group Sense Ltd.

        = 0x0072
          ShangHai Super Smart Electronics Co. Ltd.

        = 0x0071
          connectBlue AB

        = 0x0070
          Monster, LLC

        = 0x006F
          Sound ID

        = 0x006E
          Summit Data Communications, Inc.

        = 0x006D
          BriarTek, Inc

        = 0x006C
          Beautiful Enterprise Co., Ltd.

        = 0x006B
          Polar Electro OY

        = 0x006A
          MindTree Ltd.

        = 0x0069
          A&D Engineering, Inc.

        = 0x0068
          General Motors

        = 0x0067
          GN Audio A/S

        = 0x0066
          9Solutions Oy

        = 0x0065
          HP, Inc.

        = 0x0064
          Band XI International, LLC

        = 0x0063
          MiCommand Inc.

        = 0x0062
          Gibson Guitars

        = 0x0061
          RDA Microelectronics

        = 0x0060
          RivieraWaves S.A.S

        = 0x005F
          Wicentric, Inc.

        = 0x005E
          Stonestreet One, LLC

        = 0x005D
          Realtek Semiconductor Corporation

        = 0x005C
          Belkin International, Inc.

        = 0x005B
          Ralink Technology Corporation

        = 0x005A
          EM Microelectronic-Marin SA

        = 0x0059
          Nordic Semiconductor ASA

        = 0x0058
          Vizio, Inc.

        = 0x0057
          Harman International Industries, Inc.

        = 0x0056
          Sony Ericsson Mobile Communications

        = 0x0055
          Plantronics, Inc.

        = 0x0054
          3DiJoy Corporation

        = 0x0053
          Free2move AB

        = 0x0052
          J&M Corporation

        = 0x0051
          Tzero Technologies, Inc.

        = 0x0050
          SiRF Technology, Inc.

        = 0x004F
          APT Ltd.

        = 0x004E
          Avago Technologies

        = 0x004D
          Staccato Communications, Inc.
        */
        Apple= 0x004C,
            /*
        = 0x004B
          Continental Automotive Systems

        = 0x004A
          Accel Semiconductor Ltd.

        = 0x0049
          3DSP Corporation

        = 0x0048
          Marvell Technology Group Ltd.

        = 0x0047
          Bluegiga

        = 0x0046
          MediaTek, Inc.

        = 0x0045
          Atheros Communications, Inc.

        = 0x0044
          Socket Mobile

        = 0x0043
          PARROT AUTOMOTIVE SAS

        = 0x0042
          CONWISE Technology Corporation Ltd

        = 0x0041
          Integrated Silicon Solution Taiwan, Inc.

        = 0x0040
          Seiko Epson Corporation

        = 0x003F
          Bluetooth SIG, Inc

        = 0x003E
          Systems and Chips, Inc

        = 0x003D
          IPextreme, Inc.

        = 0x003C
          BlackBerry Limited

        = 0x003B
          Gennum Corporation

        = 0x003A
          Panasonic Holdings Corporation

        = 0x0039
          Integrated System Solution Corp.

        = 0x0038
          Syntronix Corporation

        = 0x0037
          Mobilian Corporation

        = 0x0036
          Renesas Electronics Corporation

        = 0x0035
          Eclipse (HQ Espana) S.L.

        = 0x0034
          Computer Access Technology Corporation (CATC)

        = 0x0033
          Commil Ltd

        = 0x0032
          Red-M (Communications) Ltd

        = 0x0031
          Synopsys, Inc.

        = 0x0030
          ST Microelectronics

        = 0x002F
          MewTel Technology Inc.

        = 0x002E
          Norwood Systems

        = 0x002D
          GCT Semiconductor

        = 0x002C
          Macronix International Co. Ltd.

        = 0x002B
          Tenovis

        = 0x002A
          Symbol Technologies, Inc.

        = 0x0029
          Hitachi Ltd

        = 0x0028
          R F Micro Devices

        = 0x0027
          Open Interface

        = 0x0026
          C Technologies

        = 0x0025
          NXP B.V.

        = 0x0024
          Alcatel

        = 0x0023
          WavePlus Technology Co., Ltd.

        = 0x0022
          NEC Corporation

        = 0x0021
          Mansella Ltd

        = 0x0020
          BandSpeed, Inc.

        = 0x001F
          AVM Berlin

        = 0x001E
          Inventel

        = 0x001D
          Qualcomm

        = 0x001C
          Conexant Systems Inc.

        = 0x001B
          Signia Technologies, Inc.

        = 0x001A
          TTPCom Limited

        = 0x0019
          Rohde & Schwarz GmbH & Co. KG

        = 0x0018
          Transilica, Inc.

        = 0x0017
          Newlogic

        = 0x0016
          KC Technology Inc.

        = 0x0015
          RTX A/S

        = 0x0014
          Mitsubishi Electric Corporation

        = 0x0013
          Atmel Corporation

        = 0x0012
          Zeevo, Inc.

        = 0x0011
          Widcomm, Inc.

        = 0x0010
          Mitel Semiconductor

        = 0x000F
          Broadcom Corporation

        = 0x000E
          Parthus Technologies Inc.

        = 0x000D
          Texas Instruments Inc.

        = 0x000C
          Digianswer A/S

        = 0x000B
          Silicon Wave

        = 0x000A
          Qualcomm Technologies International, Ltd. (QTIL)

        = 0x0009
          Infineon Technologies AG*/

        Motorola = 0x0008,

        Lucent = 0x0007,

        Microsoft = 0x0006,

        ThreeCom = 0x0005,

        Toshiba = 0x0004,

        IBM = 0x0003,

        Intel = 0x0002,

        NokiaMobilePhones = 0x0001,

        Ericsson = 0x0000,
    }
}