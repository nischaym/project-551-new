@ModelType IEnumerable(Of Models.Park)

@Code
    ViewData("Title") = "Parks"
End Code

<h2>Parks</h2>

<h2>@ViewData("Message").</h2>

<div class="container">
    <div class="row">
        @For Each item In Model
            Dim currentItem = item
            @<div class="card col-md-4 col-lg-4 col-sm-6">
                     <img src="@currentItem.PhotoPath" class="card-img-top" alt="..." style="width: 100%;">
                     <div class="card-body">
                         <h5 class="card-title">@currentItem.Name</h5>
                         <p class="card-text">@currentItem.Description</p>
                         <a href="https://www.nps.gov/yose/index.htm" target="_blank" class="btn btn-primary">Visit @currentItem.Name</a>
                     </div>
            </div>
        Next
    </div>
</div>
