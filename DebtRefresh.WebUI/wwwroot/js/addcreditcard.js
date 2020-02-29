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
                InterestRate: 0.30,
                StartDate: '1/1/2020',
                EndDate: '6/30/2020'
            },
            {
                InterestRate: 0.60,
                StartDate: '7/1/2020',
                EndDate: '12/31/2020'
            }
        ]
    },
    methods: {
        addInterestRate: function (event) {                   
            this.InterestRates.push({});
        },
        removeInterestRate: function (event) {            
            this.InterestRates.pop({});
        },    
        addCard: function (event) {
            //alert(JSON.parse(JSON.stringify(app.$data)));
            //Try this tonight: https://www.linkedin.com/pulse/post-data-from-vuejs-aspnet-core-using-axios-adeyinka-oluwaseun
            axios({
                method: 'post',
                url: '/CreditCard/Create',
                data: {
                    "Json": JSON.stringify(app.$data)                   
                },
                header: {'Content-Type': 'application/json'}
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