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

type ParentalStay = {
    HusbandsMother: StateOfExistence
    HusbandsFather: StateOfExistence
    WifesMother:    StateOfExistence
    WifesFather:    StateOfExistence
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


type PersonType =
| Husband
| Wife
| HusbandsMother
| HusbandsFather
| WifesMother
| WifesFather
| Friend
| FamilyMember
| Other

type Person = {
    Name:                     string
    PersonType:               PersonType
    PhysicalHealth:           PhysicalHealth
    MentalHealth:             MentalHealth
    CompanionshipRequirement: CompanionshipRequirement
}

type Wife = {
    CanAffordToBeWithoutWifeRightNow:   bool
    CanAffordToBeWithoutMotherRightNow: bool
}

type Husband = {
    CanAffordToNotCodeRightNow: bool
}

type Child =
| Husband of Husband
| Wife    of Wife

type Parent = {
    IsParentOf:     Option<Person>
}


type OccasionName = 
| Birthday
| EidUlFitr
| EidUlAzha
| EidEMiladUnNabi
| ShabEBarat
| Anniversary
| RegularDay
| Other of string

type OccasionCategory =
| Cultural
| Social
| Religious
| Recreational
| Other

type AttendanceRequirement = List<Person*Necessity>

type Occasion = {
    Name:     OccasionName
    Category: OccasionCategory
    AttendanceRequirement: AttendanceRequirement
}