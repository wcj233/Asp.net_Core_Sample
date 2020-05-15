window.exampleJsFunctions = {
    showPrompt: function (lastNameRef, firstNameRef, dateRef, phoneNameRef) {
        if (lastNameRef.value == "" || firstNameRef.value == "" || dateRef.value == "" || phoneNameRef.value == "") {
            alert('Please complete your input');
            return false;
        } else {
            return true;
        }
    },

    Back: function(){
        history.go(-1);
    }
    
        
};