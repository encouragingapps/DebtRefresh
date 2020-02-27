var app = new Vue({
    el: '#app',
    data: {
        CardVendor: '',
        CardNickname: '',
        CardType: '',
        CardLimit: '',
        CardBalance: '',
        InterestRates: [
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
        removeInterestRate: function (event) {            
            this.interestRates.pop({});
        },    
        addCard: function (event) {
            //alert(JSON.parse(JSON.stringify(app.$data)));
            //Try this tonight: https://www.linkedin.com/pulse/post-data-from-vuejs-aspnet-core-using-axios-adeyinka-oluwaseun
            axios({
                method: 'post',
                url: '/CreditCard/Create',
                data: {
                    "CardVendor": this.CardVendor,
                    "CardNickname": this.CardNickname,
                    "CardType": this.CardType,
                    "CardLimit": this.CardLimit,
                    "CardBalance": this.CardBalance
                }
            })
                .then(function (response) {
                    console.log(response);
                })
                .catch(function (error) {
                    console.log(error);
                });
           
        }    

    }
})