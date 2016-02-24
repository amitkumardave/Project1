using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class EntityAttributes : iEntityAttribute
    {
      

        public string attributeName
        {

            get;
            set;
        }
        public Guid attributeId
        {
            get;
            set;


        }
        public string dataType
        {

            get;
            set;
        }

        public decimal length
        {

            get;
            set;
        }

        public bool auditRequired
        {
            get;
            set;
        }

        public bool isPrimaryKey
        {

            get;
            set;
        }

        List<AttributeRelation> Relations
        {
            get;
            set;
        }

        List<AttributeValidationRule> ValidationRules
        {
            get;
            set;
        }



    }




    public class AttributeValidationRule
    {
        
        
        
        
        enum ValidationType
        {
            IntValuesOnly,
            DecimalValues,
            OnlyAlphabets,
            CanNotBeBlank,
            EmailAddress,
            PhoneNumber,
            RangeValue,
            CompareValue,
            RegularExpression             


        }

        ValidationType validationRuleType
        {
            get;
            set;
        }


        /// <summary>
        /// /TODO implement specialized function to implement validation type
        /// </summary>

        public bool validate(string strValue)
        {
            return false;
        }

        public bool validate(int intValue)
        {
            return false;
        }

        public bool validate(decimal decValue)
        {
            return false;
        }
        public bool validate(string strValue1, string strValue2)
        {
            return false;
        }

        public bool validate(int intValue1, int intValue2)
        {
            return false;
        }

        public bool validate(decimal decValue1, decimal decValue2)
        {
            return false;
        }
        public bool validate(DateTime dtValue1, DateTime  dtValue2)
        {
            return false;
        }

         


    
    

    
    
    
    }

    public class AttributeRelation
    {
        Guid parentAttribute
        {
            get;
            set;
        }
        Guid childAttribute
        {
            get;
            set;

        }
        bool enforceViaTrigger
        {
            get;
            set;
        }

        



    }
    
    public interface iEntityAttribute
    {

         Guid attributeId
        {
            get;
            set;


        }

         string attributeName
        {

            get;
            set;
        }
         string dataType
        {

            get;
            set;
        }

         decimal length
        {

            get;
            set;
        }

         bool auditRequired
        {
            get;
            set;
        }

         bool isPrimaryKey
        {

            get;
            set;
        }

    }


}
