let jsonData;const Filters={searchKey:$('#searchInput'),activeFilter:$('#contentTypes'),category:$("#categoryDropdown"),genre:$("#genreDropdown"),audio:$("#languageDropdown"),subtitle:$("#subtitleDropdown"),order:$("#sortingDropdown"),flightDate:$("#flightDateDropdown"),flightFrom:$("#flightFromDropdown"),flightTo:$("#flightToDropdown"),flightNumber:$("#flightNumberDropdown"),}
$(document).ready(function(){let culture=window.location.pathname.split("/")[1];FetchData(`/${culture}/data.json`);Filters.searchKey.on('keyup',function(e){if(e.key==='Enter'||e.keyCode===13){TriggerSearch();}});$('#contentTypes>button').on("click",function(e){let target=$(e.target);if(target.hasClass("active"))
return;$('#contentTypes').find($('.active')).removeClass("active");target.addClass("active");TriggerSearch();})
$('.dropdown-change-event').on("change",TriggerSearch)
Filters.searchKey.on("change",TriggerSearch)});const TriggerSearch=()=>{let results=[];let filters=GetFilterValues();if(filters.activeFilter=='all'||filters.activeFilter=='audio'){let filteredResults=jsonData.IndexView.Audios.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false
return true})
results=[...results,...filteredResults];}
if(filters.activeFilter=='all'||filters.activeFilter=='series'){let filteredResults=jsonData.IndexView.Tvs.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false
if(filters.genre!=""&&!elem.Genre.includes(filters.genre))
return false
if(filters.audio!=""&&filters.audio!=undefined&&!elem.Dubs?.filter((e)=>e==filters.audio).length)
return false
if(filters.subtitle!=""&&filters.subtitle!=undefined&&!elem.Subs?.filter((e)=>e==filters.subtitle).length)
return false
return true;})
results=[...results,...filteredResults];}
if(filters.activeFilter=='all'||filters.activeFilter=='movies'){let filteredResults=jsonData.IndexView.Movies.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false
if(filters.genre!=""&&!elem.Genre.includes(filters.genre))
return false
if(filters.audio!=""&&filters.audio!=undefined&&!elem.Dubs?.filter((e)=>e==filters.audio).length)
return false
if(filters.subtitle!=""&&filters.subtitle!=undefined&&!elem.Subs?.filter((e)=>e==filters.subtitle).length)
return false
return true;})
results=[...results,...filteredResults];}
if(filters.order=="Asc"){results=results.sort((a,b)=>a.Name.localeCompare(b.Name))}else{results=results.sort((b,a)=>a.Name.localeCompare(b.Name))}
LoadResults(results);}
const FetchData=(url)=>{$.getJSON(url,res=>jsonData=res);}
const ResetSearchKeyInput=()=>{Filters.searchKey.val("")
TriggerSearch();}
const ResetContentFilters=()=>{$('#contentTypes').find($('.active')).removeClass("active");$($('#contentTypes').children()[0]).addClass("active");Filters.category.val("-1");Filters.genre.val("-1");Filters.audio.val("-1");Filters.subtitle.val("-1");Filters.order.val("1");Filters.flightDate.val("-1");Filters.flightFrom.val("-1");Filters.flightTo.val("-1");Filters.flightNumber.val("-1");TriggerSearch()}
const GetFilterValues=()=>{return{searchKey:Filters.searchKey.val(),activeFilter:Filters.activeFilter.find(".active").data().value,category:Filters.category.find($('option:selected')).text(),genre:Filters.genre.find($('option:selected')).text(),audio:Filters.audio.find($('option:selected')).text(),subtitle:Filters.subtitle.find($('option:selected')).text(),order:Filters.order.find($('option:selected')).text(),flightDate:Filters.flightDate.find($('option:selected')).text(),flightFrom:Filters.flightFrom.find($('option:selected')).text(),flightTo:Filters.flightTo.find($('option:selected')).text(),flightNumber:Filters.flightNumber.find($('option:selected')).text(),}}
const LoadResults=(results)=>{let parentElem=$('#searchResults');parentElem.empty();parentElem.append('<div class="container">')
let container=$(parentElem.children()[0])
container.append(RenderResultCount(results.length));container.append(RenderMobileFilters());container.append(RenderResultCards(results))}
const RenderResultCount=(num)=>{return`<p class="search-results__title hide-tablet"> Search Results <span>(${num})</span></p>`}
const RenderMobileFilters=()=>{return`<div class="d-flex d-md-none justify-content-between align-items-center mb-4">

                <p class="search-results__title mb-0"> </p>

                <button class="btn-outline btn-rounded btn-outline-mobile">Filter</button>

            </div>`;}
const RenderResultCards=(items)=>{let html='<div class="row row-cols-lg-5 ">';items.forEach((elem)=>html+=RenderCard(elem))
html+='</div>'
return html;}
const RenderCard=(item)=>{return`<div class="col col-6 col-md-3">



    <a href="${item.HtmlName}.html" target="_blank">

        <div class="search-results__item">

            <img ${item.Image?.length ? 'src="' + item.Image + '"' : ""}/>

            <!-- item type v1.0 -->

            <div class="search-results__item-type d-none">

                <svg class="all fill-white">

                    <use xlink:href="../wwwroot/all.svg#${GetContentTypeIcon(item)}"></use>

                </svg>

            </div>

        </div>

    </a>



    <!-- item type v1.1 -->

    <div class="d-flex justify-content-between align-items-center mb-4">

        <div style="max-width: 80%;">

            <p class="search-results__item-title mb-0 mt-2">${item.Name}<span></span></p>

            <p class="search-results__item-info"><span>${item.Year}</span> | <span>${item.Duration}</span></p>

        </div>

        <div>

            <div class="search-results__item-type">

                <svg class="all fill-primary">

                    <use xlink:href="../wwwroot/all.svg#${GetContentTypeIcon(item)}"></use>

                </svg>

            </div>

        </div>

    </div>

</div>`}
const GetContentTypeIcon=(item)=>{if(item.hasOwnProperty("AllAudios"))
return"icon-audio";if(item.hasOwnProperty("AllTvs"))
return"icon-tv";if(item.hasOwnProperty("AllMovies"))
return"icon-movie";}