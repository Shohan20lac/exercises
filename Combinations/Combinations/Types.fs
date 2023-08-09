module AtomicTypes

type Reason = string

type Necessity = 
| Optional
| Preferred
| Mandatory

type Transport =
| Private
| Public

type AtHome           = bool
type StateOfExistence =
| InTown    of AtHome
| OutofTown of AtHome
| Abroad

type ParentalStayState = {
    HusbandMom: StateOfExistence
    HusbandDad: StateOfExistence
    WifeMom:    StateOfExistence
    WifeDad:    StateOfExistence
}

type InPersonAssistance = {
    allDay:    bool
    overnight: bool
    medical:   bool
}

type Assistance =
| VerbalInPerson
| VerbalOverPhone
| InPerson of InPersonAssistance

type CompanionshipRequirement = {
    Physical:         Option<Assistance * Necessity>
    Emotional:        Option<Assistance * Necessity>
    Medical:          Option<Assistance * Necessity>
    Transportational: Option<Transport  * Necessity>
}

type MentalHealth =
| Euphoric
| Content
| Bored      of Reason
| Lonely     of Reason
| Depressed  of Reason
| Suicidal   of Reason

type PhysicalHealth =
| FullyOperational
| Unconvenienced   of Reason * Option<CompanionshipRequirement>
| Injured          of Reason * CompanionshipRequirement
| SeverelyInjured  of Reason * CompanionshipRequirement

type Duration = 
| QuarterDay
| HalfDay
| WholeDay

type Availability = 
| Social
| MultiTasking
| Recluse

type PersonState = {
    PhysicalHealth: PhysicalHealth
    MentalHealth:   MentalHealth
    Availability:   Availability
}

type SonState = {
    personState:              PersonState
    daysSinceLastSeenParents: int
    daysSinceLastBeenToHouse: int
}

type DaughterState = {
    personState:              PersonState
    daysSinceLastSeenParents: int
    daysSinceLastBeenHome:    int
}

type HusbandState = {
    personState: PersonState
    hoursSinceLastContactedWife: int
    daysSinceLastSeenWife:       int
}

type WifeState = {
    personState: PersonState
    minutesSinceLastContactedHusband: int
    hoursSinceLastSeenHusband:        int
    CompanionshipRequirement:         CompanionshipRequirement
}

type ParentState = {
    personState:                 PersonState
    daysSinceLastSeenChild:      int
    daysSinceLastSeenChildInLaw: int
}


type PersonType =
| Husband     
| Wife
| HusbandMom
| HusbandDad
| WifeMom
| WifeDad
| Friend
| FamilyMember
| Other

type OccasionName = 
| Birthday
| EidUlFitr
| EidUlAzha
| EidEMiladUnNabi
| ShabEBarat
| Anniversary
| RegularDay
| Other of string

type OccasionType = 
| Social
| Recreational
| Religious
| Emergency

type OccasionScheduleNotice = 
| LastMinute
| Planned of int

type OccasionState = {
    ocassionName:               OccasionName
    occasionType:               OccasionType
    scheduleNotice:             OccasionScheduleNotice
    ttendanceNecessity: Necessity 
    wifeAttendanceNecessity:    Necessity
}

type Scenario = {
    husband:           PersonState   * SonState * HusbandState
    husbandDad:        ParentState
    husbandMom:        ParentState
    wife:              PersonState   * DaughterState * WifeState
    wifeMom:           ParentState
    wifeDad:           ParentState
    occasion:          OccasionState
    parentalStayState: ParentalStayState
}

type OccasionCategory =
| Cultural
| Social
| Religious
| Recreational
| Other