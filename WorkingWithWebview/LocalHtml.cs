using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class LocalHtml : ContentPage
    {
        public LocalHtml()
        {
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<!DOCTYPE html>
<html>
<head>
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no,viewport-fit=cover "">
           


                          <title> Home Page - WebApp </title>
           


                             <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
           


                                    <link rel=""stylesheet"" href=""site.css"">
           


                                       <script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>
           


                                        <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
           
<style type=""text / css"">

body {
padding-top: constant(safe-area-inset-top); /* iOS 11.0 */
padding-top: env(safe-area-inset-top); /* iOS 11.2 */
}
                </style>

                                       </head>
           
                                   
                                         <header style=""background-color: #009688!important; padding-top: 20px; padding-top: constant(safe-area-inset-top);padding-top: env(safe-area-inset-top);"">
           
                                             <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"" style=""background-color: #009688!important;"">
            <div class=""container"">
                <a class=""navbar-brand"" href=""https://mail.elsy.ru:8443/MobileApp"">WebApp</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                   <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""https://mail.elsy.ru:8443/MobileApp"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-dark"" href=""https://mail.elsy.ru:8443/MobileApp/Home/Privacy"">Privacy</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div class=""container"">
        

        <main role = ""main"" class=""pb-3"">
            
<div id = ""app"" class=""text-center""><h1 class=""display-4"">Регистрация</h1> 
<p>Введите данные для регистрации в системе.</p> 
<form>
<div class=""form-group""><input type = ""email"" name=""Email"" id=""Email"" aria-describedby=""emailHelp"" placeholder=""Email"" class=""form-control-lg"" v-model=""mymodel.email""> 
<small id = ""emailHelp"" class=""form-text text-muted""></small></div> <div class=""form-group"">
<input type = ""text"" name=""Name"" id=""Name"" aria-describedby=""NameHelp"" placeholder=""Имя"" class=""form-control-lg"" v-model=""mymodel.name""> 
<small id = ""NameHelp"" class=""form-text text-muted""></small></div> <div class=""form-group"">
<input type = ""text"" name=""Surname"" id=""Surname"" aria-describedby=""surnameHelp"" placeholder=""Фамилия"" class=""form-control-lg"" v-model=""mymodel.surname""> 
<small id = ""surnameHelp"" class=""form-text text-muted""></small></div> <div class=""form-group"">
<input type = ""tel"" name=""Phone"" id=""Phone"" aria-describedby=""phoneHelp"" placeholder=""Телефон"" class=""form-control-lg"" v-model=""mymodel.phone""> 
<small id = ""phoneHelp"" class=""form-text text-muted"">Мы не передаем ваши данные третьим лицам.</small></div> 
<div class=""form-group form-check""><input type = ""checkbox"" name=""Check"" id=""exampleCheck1"" class=""form-check-input""> 
<label for=""exampleCheck1"" class=""form-check-label"">Запомнить меня</label></div></form>
<button class=""btn btn-primary"" v-on:click=""myClickRegister"">Отправить</button>
<p>{{ guid }}</p></div>


<script>
    var myModel = {
        email: ""vasilyev_a @elsy.ru"",
        name: ""Иван"",
        surname: ""Иванов"",
        phone: ""79112222222"",
        DeviceId: '',
        ConfirmMethod: 1,
        AppVersion: ""v1.1.1""
    };

        new Vue({
        el: '#app',
        data:
            {
            mymodel: myModel,
            guid: ''
        },
        methods:
            {
            myClickRegister: function() {
                    axios({
                    method: 'POST',
                    url: 'https://mail.elsy.ru:8443/MobileApp_API/Register/Register',
                    //url: 'http://192.168.0.175/MobileApp_API/Register/Register',
                    data: this.mymodel,
                    headers: { 'Content-Type': 'application/json; charset=utf-8' }
                    }).then(response => {
                        this.guid = response.data.guid;
                        console.log(response);

                    }).catch (e => { console.log(e) });

                    // alert('guid = ' + this.guid + '!');
                    },


            async requestData()
                    {
                        this.pending = true;
                        try
                        {
                            const { data } = await axios.get(this.url, { params: this.params });
                this.data = data;
                this.error = false;
            } catch (e)
            {
                this.data = null;
                this.error = e;
            }
            this.pending = false;
        }
    },
        mounted()
    {

    }

})
</script>
        </main>
    </div>
    <footer class=""border-top footer text-muted"">
        <div class=""container text-center"">
            © 2019 - ELSY - <a href=""https://mail.elsy.ru:8443/MobileApp/Home/Privacy"">Privacy</a>
        </div>
    </footer>
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src = ""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src = ""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

</body></html>";


            browser.Source = htmlSource;
            Content = browser;
        }
    }
}
