var app = new Vue({
    el: '#app',
    data: {
        cardVendor: '',
        cardNickname: '',
        creditCardType: '',
        interestRates: [
            {
                interestRate: '0.30',
                startDate: '1/1/2020',
                endDate: '6/30/2020'
            },
            {
                interestRate: '0.60',
                startDate: '7/1/2020',
                endDate: '12/31/2020'
            }
        ]
    },
    methods: {
        addInterestRate: function (event) {                   
            this.interestRates.push({});
        },
        removeRow: function (event) {            
            this.interestRates.pop({});
        }    

    }
})