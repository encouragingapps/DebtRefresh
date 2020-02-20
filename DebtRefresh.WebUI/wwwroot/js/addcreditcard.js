var app = new Vue({
    el: '#app',
    data: {
        cardVendor: '',
        cardNickname: '',
        creditCardType: '',
        interestRates: [
            {
                interestRate: '',
                startDate: '',
                endDate: '',
            }
        ]
    },
    methods: {
        addInterestRate: function (event) {
            
            alert('Add code to add interest here!')
            
        }
    }
})