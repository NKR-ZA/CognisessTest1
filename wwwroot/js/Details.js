/// <reference path="../../wwwroot/lib/jquery/dist/jquery.js" />
/// <reference path="../../wwwroot/js/knockout.js" />

$(document).ready(function () {
    function Account(data) {
        this.Id = ko.observable(data.Id);
        this.FirstName = ko.observable(data.FirstName);
        this.LastName = ko.observable(data.LastName);
        this.Email = ko.observable(data.Email);
        this.Gender = ko.observable(data.Gender);
        this.DateOfBirth = ko.observable(data.DateOfBirth);
        this.CreatedDate = ko.observable(data.CreatedDate);
        this.LastUpdatedDate = ko.observable(data.LastUpdatedDate);
    }
    var ViewModel = function AccountViewModel() {
        var self = this;
        self.test = ko.observable("Test Word");
        self.accountArray = ko.observableArray([]);
        self.accountSubmit = ko.observable();
        self.firstName = ko.observable();
        self.lastName = ko.observable();
        self.email = ko.observable();
        self.gender = ko.observable();
        self.dateOfBirth = ko.observable();
        self.createdDate = ko.observable();
        self.lastUpdatedDate = ko.observable();
        self.deletionDate = ko.observable();
        self.isComplete = ko.observable();
        self.fetch = function () {
            //GET
            $.ajax({
                type: "GET",
                url: 'Accounts/GetData',  //your api
                success: function (result) {
                    self.accountArray([]);  //emptys the Array
                    self.accountArray(result);  //maps json object into the Array
                }
            });
        };
        self.submit = function () {
            var dataObject = {};
            dataObject.firstName = $("#firstNameDiv").val();
            dataObject.lastName = $("#lastNameDiv").val();
            dataObject.email = $("#emailDiv").val();
            dataObject.gender = $("#genderDiv").val();
            dataObject.dateOfBirth = $("#dateOfBirthDiv").val();
            //dataObject.createdDate = $("#createdDateDiv").val();
            //dataObject.lastUpdatedDate = $("#lastUpdatedDateDiv").val();
            //dataObject.deletionDate = $("#deletionDateDiv").val();
            dataObject.isComplete = $("#isCompleteDiv").val();
            //POST
            $.ajax({
                type: "POST",
                dataType: "json",
               contentType: "application/json",
                url: "SaveData?firstName=" + $("#firstNameDiv").val() + "&lastName=" + $("#lastNameDiv").val() + "&email=" + $("#emailDiv").val() + "&gender=" + $("#genderDiv").val() + "&dateOfBirth=" + $("#dateOfBirthDiv").val()  + "&isComplete=" + $("#isCompleteDiv").val(),
                data: dataObject,
                success: function () {
                    console.log("Okay");
                }
            });
            //$.post("SaveData", dataObject, function (data) {});
            //$.post("demo_test_post.asp",
            //    {
            //        name: "Donald Duck",
            //        city: "Duckburg"
            //    },
            //    function (data, status) {
            //        alert("Data: " + data + "\nStatus: " + status);
            //    });
        };
        
            //.fail(function (error) {
            //    if (error.status === 401) {
            //        app.showMessage("You do not have permission to access these details!");
            //    }
            //    else {
            //        app.showMessage("An error occurred");
            //    }
            //});

        self.FirstName = ko.observable();
        self.LastName = ko.observable();
        self.Email = ko.observable();
        self.Gender = ko.observable();
        self.DateOfBirth = ko.observable();
        self.CreatedDate = ko.observable();
        self.LastUpdatedDate = ko.observable();
        self.AddAccount = function () {
            self.Accounts.push(new Student({
                Id: self.Id(),
                FirstName: self.FirstName(),
                LastName: self.LastName(),
                Email: self.Email(),
                DateOfBirth: self.DateOfBirth(),
                CreatedDate: self.CreatedDate(),
                LastUpdatedDate: self.LastUpdatedDate(),
            }));
            self.Id(""), self.FirstName(""), self.LastName(""), self.Email(""), self.Gender(""), self.DateOfBirth(""), self.CreatedDate(""), self.LastUpdatedDate("")
        };
    }

        ko.applyBindings(new ViewModel());
});
