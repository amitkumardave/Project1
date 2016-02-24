using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApplication1
{
  

    class Employee
    {
        string _employeeId;

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        string _employeeFullName;

        public string EmployeeFullName
        {
            get { return _employeeFullName; }
            set { _employeeFullName = value; }
        }
        string _employeeFatherName;

        public string EmployeeFatherName
        {
            get { return _employeeFatherName; }
            set { _employeeFatherName = value; }
        }
        Address _employeeParmenentAddress;

        internal Address EmployeeParmenentAddress
        {
            get { return _employeeParmenentAddress; }
            set { _employeeParmenentAddress = value; }
        }
        Address _employeeCurrentAddress;

        internal Address EmployeeCurrentAddress
        {
            get { return _employeeCurrentAddress; }
            set { _employeeCurrentAddress = value; }
        }
        string _employeePanNo;

        public string EmployeePanNo
        {
            get { return _employeePanNo; }
            set { _employeePanNo = value; }
        }
        BankInformation _employeeBankDetails;

        internal BankInformation EmployeeBankDetails
        {
            get { return _employeeBankDetails; }
            set { _employeeBankDetails = value; }
        }
        DateTime _employeeDateOfJoining;

        public DateTime EmployeeDateOfJoining
        {
            get { return _employeeDateOfJoining; }
            set { _employeeDateOfJoining = value; }
        }
        DateTime _employeeDateOfBirth;

        public DateTime EmployeeDateOfBirth
        {
            get { return _employeeDateOfBirth; }
            set { _employeeDateOfBirth = value; }
        }
        DateTime _employeeDateOfRelease;

        public DateTime EmployeeDateOfRelease
        {
            get { return _employeeDateOfRelease; }
            set { _employeeDateOfRelease = value; }
        }
        Employee _employeeManager;

        internal Employee EmployeeManager
        {
            get { return _employeeManager; }
            set { _employeeManager = value; }
        }
        string _employeeDesignation;

        public string EmployeeDesignation
        {
            get { return _employeeDesignation; }
            set { _employeeDesignation = value; }
        }
        string _employeeLocation;

        public string EmployeeLocation
        {
            get { return _employeeLocation; }
            set { _employeeLocation = value; }
        }
        string _employeePunchCardNo;

        public string EmployeePunchCardNo
        {
            get { return _employeePunchCardNo; }
            set { _employeePunchCardNo = value; }
        }
        string _employeeEngagementType;

        public string EmployeeEngagementType
        {
            get { return _employeeEngagementType; }
            set { _employeeEngagementType = value; }
        }
        PayStructure _employeePayStructure;

        internal PayStructure EmployeePayStructure
        {
            get { return _employeePayStructure; }
            set { _employeePayStructure = value; }
        }
        List<PayStructure> _employeePayChangeHistory;

        internal List<PayStructure> EmployeePayChangeHistory
        {
            get { return _employeePayChangeHistory; }
            set { _employeePayChangeHistory = value; }
        }
        LeaveBalance _employeeLeaveRecord;

        internal LeaveBalance EmployeeLeaveRecord
        {
            get { return _employeeLeaveRecord; }
            set { _employeeLeaveRecord = value; }
        }
     }

    class Address
    {
        string _address1;

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        string _address2;

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        string _zipCode;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }   
    }

    public class BankInformation:MongoEntity
    {
        //This is comme nt
        string _bankName;

        [BsonElementAttribute("BankName")]
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }
        string _branchName;
        [BsonElementAttribute("BankBranchName")]
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }
        string _branchCity;
        [BsonElementAttribute("BankCityName")]
        public string BranchCity
        {
            get { return _branchCity; }
            set { _branchCity = value; }
        }
        string _ifscCode;
        [BsonElementAttribute("BankIFSC")]
        public string IfscCode
        {
            get { return _ifscCode; }
            set { _ifscCode = value; }
        }
        string _accountNumber;
        [BsonElementAttribute("AccountNo")]
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
    }

    class PayStructure
    {
        float _basic;

        public float Basic
        {
            get { return _basic; }
            set { _basic = value; }
        }
        float _hra;

        public float Hra
        {
            get { return _hra; }
            set { _hra = value; }
        }
        float _conveyanceAllowance;

        public float ConveyanceAllowance
        {
            get { return _conveyanceAllowance; }
            set { _conveyanceAllowance = value; }
        }
        float _medicalAllowance;

        public float MedicalAllowance
        {
            get { return _medicalAllowance; }
            set { _medicalAllowance = value; }
        }
        float _leaveTravelAllowance;

        public float LeaveTravelAllowance
        {
            get { return _leaveTravelAllowance; }
            set { _leaveTravelAllowance = value; }
        }
        float _carAllowance;

        public float CarAllowance
        {
            get { return _carAllowance; }
            set { _carAllowance = value; }
        }
        float _uniformAllowance;

        public float UniformAllowance
        {
            get { return _uniformAllowance; }
            set { _uniformAllowance = value; }
        }
        float _newsAndPeriodicsAllowance;

        public float NewsAndPeriodicsAllowance
        {
            get { return _newsAndPeriodicsAllowance; }
            set { _newsAndPeriodicsAllowance = value; }
        }
        float _otherAlloance;

        public float OtherAlloance
        {
            get { return _otherAlloance; }
            set { _otherAlloance = value; }
        }
        float _companyPf;

        public float CompanyPf
        {
            get { return _companyPf; }
            set { _companyPf = value; }
        }
        float _gratuity;

        public float Gratuity
        {
            get { return _gratuity; }
            set { _gratuity = value; }
        }
        float _bonus;

        public float Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        float _deductionEmployeePf;

        public float DeductionEmployeePf
        {
            get { return _deductionEmployeePf; }
            set { _deductionEmployeePf = value; }
        }
        float _deductionProfessionalTax;

        public float DeductionProfessionalTax
        {
            get { return _deductionProfessionalTax; }
            set { _deductionProfessionalTax = value; }
        }
        float _deductionTax;

        public float DeductionTax
        {
            get { return _deductionTax; }
            set { _deductionTax = value; }
        }
        float _otherDeduction;

        public float OtherDeduction
        {
            get { return _otherDeduction; }
            set { _otherDeduction = value; }
        }
        float _otherPayment;

        public float OtherPayment
        {
            get { return _otherPayment; }
            set { _otherPayment = value; }
        }
     }

    class LeaveBalance
    {
        float _casualLeave;

        public float CasualLeave
        {
            get { return _casualLeave; }
            set { _casualLeave = value; }
        }
        float _sickLeave;

        public float SickLeave
        {
            get { return _sickLeave; }
            set { _sickLeave = value; }
        }
        float _earnedLeave;

        public float EarnedLeave
        {
            get { return _earnedLeave; }
            set { _earnedLeave = value; }
        }
    }

    class Attendance
    {
        string _employeeId;

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        DateTime _attendanceIn;

        public DateTime AttendanceIn
        {
            get { return _attendanceIn; }
            set { _attendanceIn = value; }
        }
        DateTime _attendanceOut;

        public DateTime AttendanceOut
        {
            get { return _attendanceOut; }
            set { _attendanceOut = value; }
        }
        float _calculatedHours;

        public float CalculatedHours
        {
            get { return _calculatedHours; }
            set { _calculatedHours = value; }
        }
        bool _isNonWorkingDay;

        public bool IsNonWorkingDay
        {
            get { return _isNonWorkingDay; }
            set { _isNonWorkingDay = value; }
        }
    }

    class SalaryPayment 
    {

        string _employeeId;

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }
        SalaryMonthInformation _salaryMonth;

        internal SalaryMonthInformation SalaryMonth
        {
            get { return _salaryMonth; }
            set { _salaryMonth = value; }
        }
        float _daysPresent;

        public float DaysPresent
        {
            get { return _daysPresent; }
            set { _daysPresent = value; }
        }
        float _clTaken;

        public float ClTaken
        {
            get { return _clTaken; }
            set { _clTaken = value; }
        }
        float _slTaken;

        public float SlTaken
        {
            get { return _slTaken; }
            set { _slTaken = value; }
        }
        float _elTaken;

        public float ElTaken
        {
            get { return _elTaken; }
            set { _elTaken = value; }
        }
        float _lwpTaken;

        public float LwpTaken
        {
            get { return _lwpTaken; }
            set { _lwpTaken = value; }
        }
        BankInformation _paidInBankAccount;

        internal BankInformation PaidInBankAccount
        {
            get { return _paidInBankAccount; }
            set { _paidInBankAccount = value; }
        }
        bool _isHolded;

        public bool IsHolded
        {
            get { return _isHolded; }
            set { _isHolded = value; }
        }
        PayStructure _salaryPaid;

        internal PayStructure SalaryPaid
        {
            get { return _salaryPaid; }
            set { _salaryPaid = value; }
        }
        float _additionalDeduction;

        public float AdditionalDeduction
        {
            get { return _additionalDeduction; }
            set { _additionalDeduction = value; }
        }
        float _addtionalPayment;

        public float AddtionalPayment
        {
            get { return _addtionalPayment; }
            set { _addtionalPayment = value; }
        }
    }

    class SalaryMonthInformation
    {

        int _Month;

        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }
        int _Year;

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        int _publicHoliday;

        public int PublicHoliday
        {
            get { return _publicHoliday; }
            set { _publicHoliday = value; }
        }
        int _weekOffs;

        public int WeekOffs
        {
            get { return _weekOffs; }
            set { _weekOffs = value; }
        }
        int _otherClosedDays;

        public int OtherClosedDays
        {
            get { return _otherClosedDays; }
            set { _otherClosedDays = value; }
        }
      }


    class LeaveRecord 
    {
        string _employeeID;

        public string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        DateTime _leaveTaken;

        public DateTime LeaveTaken
        {
            get { return _leaveTaken; }
            set { _leaveTaken = value; }
        }
        bool _clTaken;

        public bool ClTaken
        {
            get { return _clTaken; }
            set { _clTaken = value; }
        }
        bool _elTaken;

        public bool ElTaken
        {
            get { return _elTaken; }
            set { _elTaken = value; }
        }
        bool _slTaken;

        public bool SlTaken
        {
            get { return _slTaken; }
            set { _slTaken = value; }
        }
        bool _lwpTaken;

        public bool LwpTaken
        {
            get { return _lwpTaken; }
            set { _lwpTaken = value; }
        }
        bool _isCompOff;

        public bool IsCompOff
        {
            get { return _isCompOff; }
            set { _isCompOff = value; }
        }
        DateTime _compOffAgainstDate;

        public DateTime CompOffAgainstDate
        {
            get { return _compOffAgainstDate; }
            set { _compOffAgainstDate = value; }
        }
        string _leavePurpose;

        public string LeavePurpose
        {
            get { return _leavePurpose; }
            set { _leavePurpose = value; }
        }
        DateTime _requestedOn;

        public DateTime RequestedOn
        {
            get { return _requestedOn; }
            set { _requestedOn = value; }
        }
        string _requestedByEmployeeId;

        public string RequestedByEmployeeId
        {
            get { return _requestedByEmployeeId; }
            set { _requestedByEmployeeId = value; }
        }
        string _approvedByEmployeeId;

        public string ApprovedByEmployeeId
        {
            get { return _approvedByEmployeeId; }
            set { _approvedByEmployeeId = value; }
        }
        DateTime _approvedOn;

        public DateTime ApprovedOn
        {
            get { return _approvedOn; }
            set { _approvedOn = value; }
        }
        string _approvalRemarks;

        public string ApprovalRemarks
        {
            get { return _approvalRemarks; }
            set { _approvalRemarks = value; }
        }
        bool _isHalfDay;

        public bool IsHalfDay
        {
            get { return _isHalfDay; }
            set { _isHalfDay = value; }
        }
    }

    public class MongoEntity : IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }

    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
