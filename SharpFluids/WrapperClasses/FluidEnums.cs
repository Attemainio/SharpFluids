﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFluids
{

    //List of FLuids:
    //http://www.coolprop.org/fluid_properties/PurePseudoPure.html






    public enum FluidList
    {
        [MediaType("HEOS", "AMMONIA")                       ] Ammonia,
        [MediaType("HEOS", "AIR")                           ] Air,
        [MediaType("HEOS", "CARBONDIOXIDE")                 ] CO2,
        [MediaType("HEOS", "1BUTENE")                       ] Butene1,
        [MediaType("HEOS", "ACETONE")                       ] Acetone,
        [MediaType("HEOS", "ARGON")                         ] Argon,
        [MediaType("HEOS", "BENZENE")                       ] Benzene,
        [MediaType("HEOS", "CARBONMONOXIDE")                ] CO,
        [MediaType("HEOS", "CARBONYLSULFIDE")               ] CarbonylSulfide,
        [MediaType("HEOS", "CYCLOHEXANE")                   ] CycloHexane,
        [MediaType("HEOS", "CYCLOPROPANE")                  ] CycloPropane,
        [MediaType("HEOS", "CYCLOPENTANE")                  ] Cyclopentane,
        [MediaType("HEOS", "OCTAMETHYLCYCLOTETRASILOXANE")  ] D4,
        [MediaType("HEOS", "DECAMETHYLCYCLOPENTASILOXANE")  ] D5,
        [MediaType("HEOS", "DODECAMETHYLCYCLOHEXASILOXANE") ] D6,
        [MediaType("HEOS", "DEUTERIUM")                     ] Deuterium,
        [MediaType("HEOS", "DICHLOROETHANE")                ] Dichloroethane,
        [MediaType("HEOS", "DEE")                           ] DiethylEther,
        [MediaType("HEOS", "DIMETHYLCARBONATE")             ] DimethylCarbonate,
        [MediaType("HEOS", "DIMETHYLETHER")                 ] DimethylEther,
        [MediaType("HEOS", "ETHANE")                        ] Ethane,
        [MediaType("HEOS", "ETHANOL")                       ] Ethanol,
        [MediaType("HEOS", "ETHYLBENZENE")                  ] EthylBenzene,
        [MediaType("HEOS", "ETHYLENE")                      ] Ethylene,
        [MediaType("HEOS", "ETHYLENEOXIDE")                 ] EthyleneOxide,
        [MediaType("HEOS", "FLUORINE")                      ] Fluorine,
        [MediaType("HEOS", "RE143A")                        ] HFE143m,
        [MediaType("HEOS", "HEAVYWATER")                    ] HeavyWater,
        [MediaType("HEOS", "HELIUM")                        ] Helium,
        [MediaType("HEOS", "HYDROGEN")                      ] Hydrogen,
        [MediaType("HEOS", "HYDROGENCHLORIDE")              ] HydrogenChloride,
        [MediaType("HEOS", "HYDROGENSULFIDE")               ] HydrogenSulfide,
        [MediaType("HEOS", "ISOBUTANE")                     ] IsoButane,
        [MediaType("HEOS", "ISOBUTENE")                     ] IsoButene,
        [MediaType("HEOS", "ISOHEXANE")                     ] Isohexane,
        [MediaType("HEOS", "ISOPENTANE")                    ] Isopentane,
        [MediaType("HEOS", "KRYPTON")                       ] Krypton,
        [MediaType("HEOS", "DECAMETHYLTETRASILOXANE")       ] MD2M,
        [MediaType("HEOS", "DODECAMETHYLPENTASILOXANE")     ] MD3M,
        [MediaType("HEOS", "TETRADECAMETHYLHEXASILOXANE")   ] MD4M,
        [MediaType("HEOS", "OCTAMETHYLTRISILOXANE")         ] MDM,
        [MediaType("HEOS", "HEXAMETHYLDISILOXANE")          ] MM,
        [MediaType("HEOS", "METHANE")                       ] Methane,
        [MediaType("HEOS", "METHANOL")                      ] Methanol,
        [MediaType("HEOS", "METHYLLINOLEATE")               ] MethylLinoleate,
        [MediaType("HEOS", "METHYLLINOLENATE")              ] MethylLinolenate,
        [MediaType("HEOS", "METHYLOLEATE")                  ] MethylOleate,
        [MediaType("HEOS", "METHYLPALMITATE")               ] MethylPalmitate,
        [MediaType("HEOS", "METHYLSTEARATE")                ] MethylStearate,
        [MediaType("HEOS", "NEON")                          ] Neon,
        [MediaType("HEOS", "NEOPENTANE")                    ] Neopentane,
        [MediaType("HEOS", "NITROGEN")                      ] Nitrogen,
        [MediaType("HEOS", "NITROUSOXIDE")                  ] NitrousOxide,
        [MediaType("HEOS", "NOVEC649")                      ] Novec649,
        [MediaType("HEOS", "ORTHODEUTERIUM")                ] OrthoDeuterium,
        [MediaType("HEOS", "ORTHOHYDROGEN")                 ] OrthoHydrogen,
        [MediaType("HEOS", "OXYGEN")                        ] Oxygen,
        [MediaType("HEOS", "PARADEUTERIUM")                 ] ParaDeuterium,
        [MediaType("HEOS", "PARAHYDROGEN")                  ] ParaHydrogen,
        [MediaType("HEOS", "PROPYLENE")                     ] Propylene,
        [MediaType("HEOS", "PROPYNE")                       ] Propyne,
        [MediaType("HEOS", "R11")                           ] R11,
        [MediaType("HEOS", "R113")                          ] R113,
        [MediaType("HEOS", "R114")                          ] R114,
        [MediaType("HEOS", "R115")                          ] R115,
        [MediaType("HEOS", "R116")                          ] R116,
        [MediaType("HEOS", "R12")                           ] R12,
        [MediaType("HEOS", "R123")                          ] R123,
        [MediaType("HEOS", "R1233ZDE")                      ] R1233zdE,
        [MediaType("HEOS", "R1234YF")                       ] R1234yf,
        [MediaType("HEOS", "R1234ZE")                       ] R1234zeE,
        [MediaType("HEOS", "R1234ZE(Z)")                    ] R1234zeZ,
        [MediaType("HEOS", "R124")                          ] R124,
        [MediaType("HEOS", "R1234ZF")                       ] R1243zf,
        [MediaType("HEOS", "R125")                          ] R125,
        [MediaType("HEOS", "R13")                           ] R13,
        [MediaType("HEOS", "R134A")                         ] R134a,
        [MediaType("HEOS", "R13I1")                         ] R13I1,
        [MediaType("HEOS", "R14")                           ] R14,
        [MediaType("HEOS", "R141B")                         ] R141b,
        [MediaType("HEOS", "R142B")                         ] R142b,
        [MediaType("HEOS", "R143A")                         ] R143a,
        [MediaType("HEOS", "R152A")                         ] R152A,
        [MediaType("HEOS", "R161")                          ] R161,
        [MediaType("HEOS", "R21")                           ] R21,
        [MediaType("HEOS", "R218")                          ] R218,
        [MediaType("HEOS", "R22")                           ] R22,
        [MediaType("HEOS", "R227EA")                        ] R227EA,
        [MediaType("HEOS", "R23")                           ] R23,
        [MediaType("HEOS", "R236EA")                        ] R236EA,
        [MediaType("HEOS", "R236FA")                        ] R236FA,
        [MediaType("HEOS", "R245ca")                        ] R245ca,
        [MediaType("HEOS", "R245fa")                        ] R245fa,
        [MediaType("HEOS", "R32")                           ] R32,
        [MediaType("HEOS", "R365MFC")                       ] R365MFC,
        [MediaType("HEOS", "MethylChloride")                ] R40,
        [MediaType("HEOS", "R404A")                         ] R404A,
        [MediaType("HEOS", "R407C")                         ] R407C,
        [MediaType("HEOS", "R41")                           ] R41,
        [MediaType("HEOS", "R410A")                         ] R410A,
        [MediaType("HEOS", "R507A")                         ] R507A,
        [MediaType("HEOS", "RC318")                         ] RC318,
        [MediaType("HEOS", "SES36")                         ] SES36,
        [MediaType("HEOS", "SULFURDIOXIDE")                 ] SulfurDioxide,
        [MediaType("HEOS", "SULFURHEXAFLUORIDE")            ] SulfurHexafluoride,
        [MediaType("HEOS", "TOLUENE")                       ] Toluene,
        [MediaType("HEOS", "WATER")                         ] Water,
        [MediaType("HEOS", "XENON")                         ] Xenon,
        [MediaType("HEOS", "C2BUTENE")                      ] C2Butene,
        [MediaType("HEOS", "M-XYLENE")                      ] mXylene,
        [MediaType("HEOS", "N-BUTANE")                      ] nButane,
        [MediaType("HEOS", "N-DECANE")                      ] nDecane,
        [MediaType("HEOS", "N-DODECANE")                    ] nDodecane,
        [MediaType("HEOS", "N-HEPTANE")                     ] nHeptane,
        [MediaType("HEOS", "N-HEXANE")                      ] nHexane,
        [MediaType("HEOS", "N-NONANE")                      ] nNonane,
        [MediaType("HEOS", "N-OCTANE")                      ] nOctane,
        [MediaType("HEOS", "N-PENTANE")                     ] nPentane,
        [MediaType("HEOS", "N-PROPANE")                     ] nPropane,
        [MediaType("HEOS", "N-UNDECANE")                    ] nUndecane,
        [MediaType("HEOS", "O-XYLENE")                      ] oXylene,
        [MediaType("HEOS", "P-XYLENE")                      ] pXylene,
        [MediaType("HEOS", "TRANS-2-BUTENE")                ] T2Butene,


        //Incompressible
        [MediaType("INCOMP", "AS10")                        ] InCompAspenTemperMinus10,
        [MediaType("INCOMP", "AS20")                        ] InCompAspenTemperMinus20,
        [MediaType("INCOMP", "AS30")                        ] InCompAspenTemperMinus30,
        [MediaType("INCOMP", "AS40")                        ] InCompAspenTemperMinus40,
        [MediaType("INCOMP", "AS55")                        ] InCompAspenTemperMinus55,
        [MediaType("INCOMP", "DEB")                         ] InCompDiethylbenzeneMixture,
        [MediaType("INCOMP", "DowJ")                        ] InCompDowthermJ,
        [MediaType("INCOMP", "DowJ2")                       ] InCompDowthermJMix,
        [MediaType("INCOMP", "DowQ")                        ] InCompDowthermQ,
        [MediaType("INCOMP", "DowQ2")                       ] InCompDowthermQMix,
        [MediaType("INCOMP", "HC10")                        ] InCompDynaleneHC10,
        [MediaType("INCOMP", "HC20")                        ] InCompDynaleneHC20,
        [MediaType("INCOMP", "HC30")                        ] InCompDynaleneHC30,
        [MediaType("INCOMP", "HC40")                        ] InCompDynaleneHC40,
        [MediaType("INCOMP", "HC50")                        ] InCompDynaleneHC50,
        [MediaType("INCOMP", "HCB")                         ] InCompHydrocarbonBlend,
        [MediaType("INCOMP", "HCM")                         ] InCompHydrocarbonMixture,
        [MediaType("INCOMP", "HFE")                         ] InCompHFE71003M,
        [MediaType("INCOMP", "HFE2")                        ] InCompHFE7100,
        [MediaType("INCOMP", "HY20")                        ] InCompHYCOOL20,
        [MediaType("INCOMP", "HY30")                        ] InCompHyCool30,
        [MediaType("INCOMP", "HY40")                        ] InCompHyCool40,
        [MediaType("INCOMP", "HY45")                        ] InCompHyCool45,
        [MediaType("INCOMP", "HY50")                        ] InCompHyCool50,
        [MediaType("INCOMP", "NBS")                         ] InCompNBSWater,
        [MediaType("INCOMP", "NaK")                         ] InCompNitrateSalt,
        [MediaType("INCOMP", "PBB")                         ] InCompPiroblocHTF,
        [MediaType("INCOMP", "PCL")                         ] InCompParacryol,
        [MediaType("INCOMP", "PCR")                         ] InCompParathermCR,
        [MediaType("INCOMP", "PGLT")                        ] InCompParathermGLT,
        [MediaType("INCOMP", "PHE")                         ] InCompParathermHE,
        [MediaType("INCOMP", "PHR")                         ] InCompParathermHR,
        [MediaType("INCOMP", "PLR")                         ] InCompParathermLR,
        [MediaType("INCOMP", "PMR")                         ] InCompParathermMR,
        [MediaType("INCOMP", "PMS1")                        ] InCompPolydimethylsiloxan1,
        [MediaType("INCOMP", "PMS2")                        ] InCompPolydimethylsiloxan2,
        [MediaType("INCOMP", "PNF")                         ] InCompParathermNF,
        [MediaType("INCOMP", "PNF2")                        ] InCompParathermNF2,
        [MediaType("INCOMP", "S800")                        ] InCompSyltherm800,
        [MediaType("INCOMP", "SAB")                         ] InCompMarlothermX,
        [MediaType("INCOMP", "T66")                         ] InCompTherminol66,
        [MediaType("INCOMP", "T72")                         ] InCompTherminol72,
        [MediaType("INCOMP", "TCO")                         ] InCompCitrusOilTerpene,
        [MediaType("INCOMP", "TD12")                        ] InCompTherminolD12,
        [MediaType("INCOMP", "TVP1")                        ] InCompTherminolVP1,
        [MediaType("INCOMP", "TVP1869")                     ] InCompThermogenVP,
        [MediaType("INCOMP", "TX22")                        ] InCompTexatherm22,
        [MediaType("INCOMP", "TY10")                        ] InCompTyfoxit10,
        [MediaType("INCOMP", "TY15")                        ] InCompTyfoxit15,
        [MediaType("INCOMP", "TY20")                        ] InCompTyfoxit20,
        [MediaType("INCOMP", "TY24")                        ] InCompTyfoxit24,
        [MediaType("INCOMP", "XLT")                         ] InCompSylthermXLT,
        [MediaType("INCOMP", "XLT2")                        ] InCompSylthermXLT2,
        [MediaType("INCOMP", "ZS10")                        ] InCompZitrecS10,
        [MediaType("INCOMP", "ZS25")                        ] InCompZitrecS25,
        [MediaType("INCOMP", "ZS40")                        ] InCompZitrecS40,
        [MediaType("INCOMP", "ZS45")                        ] InCompZitrecS45,
        [MediaType("INCOMP", "ZS55")                        ] InCompZitrecS55,


        //Mass Mis
        [MediaType("INCOMP", "FRE",             MixType.Mass)] MixFreezium,
        [MediaType("INCOMP", "IceEA",           MixType.Mass)] MixIceslurrywithEthanol,
        [MediaType("INCOMP", "IceNA",           MixType.Mass)] MixIceslurrywithNaCl,
        [MediaType("INCOMP", "IcePG",           MixType.Mass)] MixIceslurrywithPropyleneGlycol,
        [MediaType("INCOMP", "LiBr",            MixType.Mass)] MixLithiumbromideSolution,
        [MediaType("INCOMP", "MAM",             MixType.Mass)] MixAmmoniaAQ,
        [MediaType("INCOMP", "MAM2",            MixType.Mass)] MixMelinderAmmonia,
        [MediaType("INCOMP", "MCA",             MixType.Mass)] MixCalciumChlorideAQ,
        [MediaType("INCOMP", "MCA2",            MixType.Mass)] MixMelinderCalciumChloride,
        [MediaType("INCOMP", "MEA",             MixType.Mass)] MixEthanolAQ,
        [MediaType("INCOMP", "MEA2",            MixType.Mass)] MixMelinderEthanol,
        [MediaType("INCOMP", "MEG",             MixType.Mass)] MixEthyleneGlycolAQ,
        [MediaType("INCOMP", "MEG2",            MixType.Mass)] MixMelinderEthyleneGlycol,
        [MediaType("INCOMP", "MGL",             MixType.Mass)] MixGlycerolAQ,
        [MediaType("INCOMP", "MGL2",            MixType.Mass)] MixMelinderGlycerol,
        [MediaType("INCOMP", "MITSW",           MixType.Mass)] MixMITSeawater,
        [MediaType("INCOMP", "MKA",             MixType.Mass)] MixPotassiumAcetateAQ,
        [MediaType("INCOMP", "MKA2",            MixType.Mass)] MixMelinderPotassiumAcetate,
        [MediaType("INCOMP", "MKC",             MixType.Mass)] MixPotassiumCarbonateAQ,
        [MediaType("INCOMP", "MKC2",            MixType.Mass)] MixMelinderPotassiumCarbonate,
        [MediaType("INCOMP", "MKF",             MixType.Mass)] MixPotassiumFormateAQ,
        [MediaType("INCOMP", "MLI",             MixType.Mass)] MixLithiumChlorideAQ,
        [MediaType("INCOMP", "MMA",             MixType.Mass)] MixMethanolAQ,
        [MediaType("INCOMP", "MMA2",            MixType.Mass)] MixMelinderMethanol,
        [MediaType("INCOMP", "MMG",             MixType.Mass)] MixMgCl2AQ,
        [MediaType("INCOMP", "MMG2",            MixType.Mass)] MixMelinderMagnesiumChloride,
        [MediaType("INCOMP", "MNA",             MixType.Mass)] MixSodiumChlorideAQ,
        [MediaType("INCOMP", "MNA2",            MixType.Mass)] MixMelinderSodiumChloride,
        [MediaType("INCOMP", "MPG",             MixType.Mass)] MixPropyleneGlycolAQ,
        [MediaType("INCOMP", "MPG2",            MixType.Mass)] MixMelinderPropyleneGlycol,
        [MediaType("INCOMP", "VCA",             MixType.Mass)] MixVDICalciumCloride,
        [MediaType("INCOMP", "VKC",             MixType.Mass)] MixVDIPotassiumCarbonate,
        [MediaType("INCOMP", "VMA",             MixType.Mass)] MixVDIMethanol,
        [MediaType("INCOMP", "VMG",             MixType.Mass)] MixVDIMagnesiumChloride,
        [MediaType("INCOMP", "VNA",             MixType.Mass)] MixVDISodiumChloride,

        //Vol Mix
        [MediaType("INCOMP", "AEG",             MixType.Vol)] VolMixASHRAEEthyleneGlycol,
        [MediaType("INCOMP", "AKF",             MixType.Vol)] VolMixPotassiumFormate,
        [MediaType("INCOMP", "AL",              MixType.Vol)] VolMixAntifrogenPropyleneGlycol,
        [MediaType("INCOMP", "AN",              MixType.Vol)] VolMixAntifrogenEthyleneGlycol,
        [MediaType("INCOMP", "APG",             MixType.Vol)] VolMixASHRAEPropyleneGlycol,
        [MediaType("INCOMP", "GKN",             MixType.Vol)] VolMixGlykosolEthyleneGlycol,
        [MediaType("INCOMP", "PK2",             MixType.Vol)] VolMixPekasol2000,
        [MediaType("INCOMP", "PKL",             MixType.Vol)] VolMixPropyleneGlycol,
        [MediaType("INCOMP", "ZAC",             MixType.Vol)] VolMixCorrosionInhibitor,
        [MediaType("INCOMP", "ZFC",             MixType.Vol)] VolMixFCPropyleneGlycol,
        [MediaType("INCOMP", "ZLC",             MixType.Vol)] VolMixLCPropyleneGlycol,
        [MediaType("INCOMP", "ZM",              MixType.Vol)] VolMixMEthyleneGlycol,
        [MediaType("INCOMP", "ZMC",             MixType.Vol)] VolMixMCEthyleneGlycol,




    }





}
