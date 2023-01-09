let jsonData;let jsonFlights;const Filters={searchKey:$('#searchInput'),activeFilter:$('#contentTypes'),category:$("#categoryDropdown"),genre:$("#genreDropdown"),audio:$("#languageDropdown"),subtitle:$("#subtitleDropdown"),order:$("#sortingDropdown"),flightDate:$("#flightDateDropdown"),flightFrom:$("#flightFromDropdown"),flightTo:$("#flightToDropdown"),flightNumber:$("#flightNumberDropdown")};const ActiveContentTypeOption={All:"all",Audio:"audio",TV:"series",Movies:"movies"}
$(document).ready(function(){let culture=window.location.pathname.split("/")[1];const AsyncInit=async()=>{await $.getJSON(`/${culture}/data.json`,res=>jsonData=res);await $.getJSON(`/flights.json`,res=>jsonFlights=res);UpdateFiltersOptions();InitializeFlightsDropdown();let flightSessionStorage=GetFlightFromSession();if(flightSessionStorage){ExpandendFiltersRestoreValues(flightSessionStorage,true);TriggerSearch();SetModalInitialData(flightSessionStorage);if(flightSessionStorage.category!=""||flightSessionStorage.activeFilter!="all"||flightSessionStorage.genre!=""||flightSessionStorage.audio!=""||flightSessionStorage.subtitle!=""||!(flightSessionStorage.order=="Asc"||flightSessionStorage.order=="")||flightSessionStorage.flightDate!=""||flightSessionStorage.flightFrom!=""||flightSessionStorage.flightTo!=""||flightSessionStorage.flightNumber!=""){$("#contentFilters").collapse('show');UpdateFiltersVisibility();}}};AsyncInit();Filters.searchKey.on('keyup',function(e){if(e.key==='Enter'||e.keyCode===13){TriggerSearch();}});$('#contentTypes>button').on("click",function(e){let target=$(e.target);if(target.hasClass("active"))
return;$('#contentTypes').find($('.active')).removeClass("active");target.addClass("active");UpdateFiltersVisibility();TriggerSearch();});$('.dropdown-change-event').on("change",TriggerSearch);$('.modalDestination-dropdown').on('change',FilterModalDestinationOptions);$('.modalflightNumber-dropdown').on('change',FilterModalFlightOptions);Filters.searchKey.on("change",TriggerSearch);});const TriggerSearch=()=>{let results=[];let filters=GetFilterValues();StoreFlightOnSession(filters);if(filters.activeFilter==ActiveContentTypeOption.All||filters.activeFilter==ActiveContentTypeOption.Audio){let filteredResults=jsonData.IndexView.Audios.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false;return true;})
results=[...results,...filteredResults];};if(filters.activeFilter==ActiveContentTypeOption.All||filters.activeFilter==ActiveContentTypeOption.TV){let filteredResults=jsonData.IndexView.Tvs.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false;if(filters.genre!=""&&!elem.Genre.includes(filters.genre))
return false;if(filters.audio!=""&&!(filters.audio!=-1||filters.audio!=undefined)&&!elem.Dubs?.filter((e)=>e.Description==filters.audio).length)
return false;if(filters.subtitle!=""&&!(filters.subtitle!=-1||filters.subtitle!=undefined)&&!elem.Subs?.filter((e)=>e.Description==filters.subtitle).length)
return false;return true;});results=[...results,...filteredResults];};if(filters.activeFilter==ActiveContentTypeOption.All||filters.activeFilter==ActiveContentTypeOption.Movies){let filteredResults=jsonData.IndexView.Movies.filter((elem)=>{if(filters.searchKey.trim()!=""&&!(elem.Name.toLowerCase().includes(filters.searchKey.toLowerCase())))
return false;if(filters.category!=""&&!elem.Category.includes(filters.category))
return false;if(filters.genre!=""&&!elem.Genre.includes(filters.genre))
return false;if(filters.audio!=""&&!(filters.audio!=-1||filters.audio!=undefined)&&!elem.Dubs?.filter((e)=>e.Description==filters.audio).length)
return false;if(filters.subtitle!=""&&!(filters.subtitle!=-1||filters.subtitle!=undefined)&&!elem.Subs?.filter((e)=>e.Description==filters.subtitle).length)
return false;return true;});results=[...results,...filteredResults];};var ifeSystem=GetIfeSystem();if(ifeSystem){console.log(`Ife System: ${ifeSystem}`);}
if(filters.order=="Asc"){results=results.sort((a,b)=>a.Name.localeCompare(b.Name));}else{results=results.sort((b,a)=>a.Name.localeCompare(b.Name));}LoadResults(results);}
const ResetSearchKeyInput=()=>{Filters.searchKey.val("")
TriggerSearch();}
const ResetContentFilters=()=>{$('#contentTypes').find($('.active')).removeClass("active");$($('#contentTypes').children()[0]).addClass("active");Filters.category.val("-1");Filters.genre.val("-1");Filters.audio.val("-1");Filters.subtitle.val("-1");Filters.order.val('Asc');UpdateFiltersVisibility();TriggerSearch();}
const GetFilterValues=()=>{return{searchKey:Filters.searchKey.val(),activeFilter:Filters.activeFilter.find(".active").data().value,category:Filters.category.find($('option:selected')).text(),genre:Filters.genre.find($('option:selected')).text(),audio:Filters.audio.find($('option:selected')).val(),subtitle:Filters.subtitle.find($('option:selected')).val(),order:Filters.order.find($('option:selected')).text(),flightDate:Filters.flightDate.find($('option:selected')).text(),flightFrom:Filters.flightFrom.find($('option:selected')).text(),flightTo:Filters.flightTo.find($('option:selected')).text(),flightNumber:Filters.flightNumber.find($('option:selected')).text()}}
const UpdateFiltersVisibility=()=>{switch(Filters.activeFilter.find(".active").data().value){case ActiveContentTypeOption.Audio:Filters.audio.val("-1");Filters.subtitle.val("-1");Filters.genre.parent().children().hide();Filters.audio.parent().children().hide();Filters.subtitle.parent().children().hide();break;case ActiveContentTypeOption.All:case ActiveContentTypeOption.TV:case ActiveContentTypeOption.Movies:Filters.category.parent().children().show();Filters.genre.parent().children().show();Filters.audio.parent().children().show();Filters.subtitle.parent().children().show();break;default:break;}
UpdateFiltersOptions();}
const UpdateFiltersOptions=()=>{switch(Filters.activeFilter.find(".active").data().value){case ActiveContentTypeOption.All:Filters.category.empty();Filters.category.append(RenderSelectOptions(jsonData.IndexView.Categories.map((x)=>x.Description).sort((a,b)=>a.localeCompare(b))));Filters.genre.empty();Filters.genre.append(RenderSelectOptions(jsonData.IndexView.Genres.map((x)=>x.Description).sort((a,b)=>a.localeCompare(b))));Filters.audio.empty();Filters.audio.append(RenderSelectOptions(jsonData.IndexView.Languages.sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));Filters.subtitle.empty();Filters.subtitle.append(RenderSelectOptions(jsonData.IndexView.Subtitles.sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));break;case ActiveContentTypeOption.Audio:Filters.category.empty();Filters.category.append(RenderSelectOptions([...new Set(jsonData.IndexView.Audios.flatMap(x=>x.Categories))].sort((a,b)=>a.localeCompare(b))));Filters.genre.empty();Filters.genre.append(RenderSelectOptions([...new Set(jsonData.IndexView.Audios.flatMap(x=>x.Genres))].sort((a,b)=>a.localeCompare(b))));break;case ActiveContentTypeOption.TV:Filters.category.empty();Filters.category.append(RenderSelectOptions([...new Set(jsonData.IndexView.Tvs.flatMap(x=>x.Categories))].sort((a,b)=>a.localeCompare(b))));Filters.genre.empty();Filters.genre.append(RenderSelectOptions([...new Set(jsonData.IndexView.Tvs.flatMap(x=>x.Genres))].sort((a,b)=>a.localeCompare(b))));Filters.audio.empty();Filters.audio.append(RenderSelectOptions([...new Set(jsonData.IndexView.Tvs.flatMap(x=>x.Dubs).filter((v,i,a)=>a.findIndex(v2=>['Description','FullDescription'].every(k=>v2[k]===v[k]))===i))].sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));Filters.subtitle.empty();Filters.subtitle.append(RenderSelectOptions([...new Set(jsonData.IndexView.Tvs.flatMap(x=>x.Subs).filter((v,i,a)=>a.findIndex(v2=>['Description','FullDescription'].every(k=>v2[k]===v[k]))===i))].sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));break;case ActiveContentTypeOption.Movies:Filters.category.empty();Filters.category.append(RenderSelectOptions([...new Set(jsonData.IndexView.Movies.flatMap(x=>x.Categories))].sort((a,b)=>a.localeCompare(b))));Filters.genre.empty();Filters.genre.append(RenderSelectOptions([...new Set(jsonData.IndexView.Movies.flatMap(x=>x.Genres))].sort((a,b)=>a.localeCompare(b))));Filters.audio.empty();Filters.audio.append(RenderSelectOptions([...new Set(jsonData.IndexView.Movies.flatMap(x=>x.Dubs).filter((v,i,a)=>a.findIndex(v2=>['Description','FullDescription'].every(k=>v2[k]===v[k]))===i))].sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));Filters.subtitle.empty();Filters.subtitle.append(RenderSelectOptions([...new Set(jsonData.IndexView.Movies.flatMap(x=>x.Subs).filter((v,i,a)=>a.findIndex(v2=>['Description','FullDescription'].every(k=>v2[k]===v[k]))===i))].sort((a,b)=>a.FullDescription.localeCompare(b.FullDescription))));break;default:break;}}
const ExpandendFiltersReloadOptions=(dates,froms,tos,flightNums)=>{Filters.flightDate.empty();Filters.flightDate.append(RenderSelectOptions(dates))
Filters.flightFrom.empty();Filters.flightFrom.append(RenderSelectOptions(froms.sort((a,b)=>a.localeCompare(b))))
Filters.flightTo.empty();Filters.flightTo.append(RenderSelectOptions(tos.sort((a,b)=>a.localeCompare(b))))
Filters.flightNumber.empty();Filters.flightNumber.append(RenderSelectOptions(flightNums.sort((a,b)=>a.length-b.length||a.localeCompare(b))))}
const ExpandendFiltersRestoreValues=(values,pageRefresh=false)=>{if(values.flightDate!=""){Filters.flightDate.val(values.flightDate)}
if(values.flightFrom!=""){Filters.flightFrom.val(values.flightFrom)}
if(values.flightTo!=""){Filters.flightTo.val(values.flightTo)}
if(values.flightNumber!=""){Filters.flightNumber.val(values.flightNumber)}
if(pageRefresh){console.log(values)
if(values.searchKey!=""){Filters.searchKey.val(values.searchKey)}
if(values.activeFilter!=""){Filters.activeFilter.children().removeClass('active');Filters.activeFilter.find($(`[data-value="${values.activeFilter
                }"]`)).addClass('active')}
if(values.category!=""){Filters.category.val(values.category)}
if(values.genre!=""){Filters.genre.val(values.genre)}
if(values.audio!=""){Filters.audio.val(values.audio)}
if(values.subtitle!=""){Filters.subtitle.val(values.subtitle)}
if(values.order!=""){Filters.order.val(values.order)}}}
const LoadResults=(results)=>{let parentElem=$('#searchResults');parentElem.empty();parentElem.append('<div class="container">');let container=$(parentElem.children()[0]);container.append(RenderResultCount(results.length));container.append(RenderMobileFilters());container.append(RenderResultCards(results));};const InitializeFlightsDropdown=()=>{let datesHtml=RenderSelectOptions([...new Set(jsonFlights.f.map(x=>x.dt))]);let flightNumsHtml=RenderSelectOptions(([...new Set(jsonFlights.f.map(x=>x.n))]).sort((a,b)=>a.length-b.length||a.localeCompare(b)));let fromHtml=RenderSelectOptions(([...new Set(jsonFlights.f.map(x=>x.d))]).sort((a,b)=>a.localeCompare(b)));let toHtml=RenderSelectOptions(([...new Set(jsonFlights.f.map(x=>x.a))]).sort((a,b)=>a.localeCompare(b)));Filters.flightDate.empty();Filters.flightDate.append(datesHtml);Filters.flightFrom.empty();Filters.flightFrom.append(fromHtml);Filters.flightTo.empty();Filters.flightTo.append(toHtml)
Filters.flightNumber.empty();Filters.flightNumber.append(flightNumsHtml);ModalDestinationTab.DateDeparture.empty();ModalDestinationTab.DateDeparture.append(datesHtml)
ModalDestinationTab.From.empty();ModalDestinationTab.From.append(fromHtml)
ModalDestinationTab.To.empty();ModalDestinationTab.To.append(toHtml)
ModalDestinationTab.FlightNumber.empty();ModalDestinationTab.FlightNumber.append(flightNumsHtml)
ModalFlightTab.DateDeparture.empty();ModalFlightTab.DateDeparture.append(datesHtml);ModalFlightTab.FlightNumber.empty();ModalFlightTab.FlightNumber.append(flightNumsHtml);}
const RenderResultCount=(num)=>{return`<p class="search-results__title hide-tablet"> Search Results <span>(${num})</span></p>`};const RenderMobileFilters=()=>{return`<div class="d-flex d-md-none justify-content-between align-items-center mb-4">
                <p class="search-results__title mb-0"> </p>
                <button class="btn-outline btn-rounded btn-outline-mobile">Filter</button>
            </div>`;};const RenderResultCards=(items)=>{let html=`<div class="row ${items?.length ? 'row-cols-lg-5' : ''
        }">`;if(items.length){items.forEach((elem)=>html+=RenderCard(elem));}else{html+=RenderNoResults(jsonData.IndexView?.Resources?.TextNoContentsFound);}html+='</div>'
return html;};const RenderCard=(item)=>{return`<div class="col col-6 col-md-3">
    <a href="${item.HtmlName
        }.html">
        <div class="search-results__item">
            <img ${item.Image?.length ? 'src="' + item.Image + '"' : ""
        }/>
            <!-- item type v1.0 -->
            <div class="search-results__item-type d-none">
                <svg class="all fill-white">
                    <use xlink:href="${item.ResourcePath}wwwroot/all.svg#${GetContentTypeIcon(item)
        }"></use>
                </svg>
            </div>
        </div>
    </a>
    <!-- item type v1.1 -->
    <div class="d-flex justify-content-between align-items-center mb-4">
        <div style="max-width: 80%;">
            <p class="search-results__item-title mb-0 mt-2">${item.Name
        }<span></span></p>
            <p class="search-results__item-info"><span>${item.Year
        }</span> | <span>${item.Duration
        }</span></p>
        </div>
        <div>
            <div class="search-results__item-type">
                <svg class="all fill-primary">
                    <use xlink:href="${item.ResourcePath}wwwroot/all.svg#${GetContentTypeIcon(item)
        }"></use>
                </svg>
            </div>
        </div>
    </div>
</div>`};const RenderNoResults=(message)=>{return`<div class="col-12">
        <div style="display:grid; place-items:center;min-height:200px"> 
            ${message?.length ? message : "No results found"
        }
        </div>
    </div>`;}
const GetContentTypeIcon=(item)=>{if(item.hasOwnProperty("AllAudios")){return"icon-audio";}
if(item.hasOwnProperty("AllTvs")){return"icon-tv";}
if(item.hasOwnProperty("AllMovies")){return"icon-movie";}};const RenderSelectOptions=(items)=>{let html='<option value="-1"></option>';if(items&&items[0].hasOwnProperty("FullDescription")){items.forEach((elem)=>html+=`<option value="${elem.Description}">${elem.FullDescription}</option>`);}else if(items){items.forEach((elem)=>html+=`<option value="${elem}">${elem}</option>`);}
return html;}
const ModalDestinationTab={DateDeparture:$('#modalDestinationDateDepart'),From:$('#modalDestinationFrom'),To:$('#modalDestinationTo'),FlightNumber:$('#modalDestinationFlightNo')}
const GetModalDestinationTabValues=()=>{return{DateDeparture:ModalDestinationTab.DateDeparture.find($('option:selected')).text(),From:ModalDestinationTab.From.find($('option:selected')).text(),To:ModalDestinationTab.To.find($('option:selected')).text(),FlightNumber:ModalDestinationTab.FlightNumber.find($('option:selected')).text()}}
const ResetModalDestinationTabValues=()=>{ModalDestinationTab.DateDeparture.val(-1);ModalDestinationTab.From.val(-1);ModalDestinationTab.To.val(-1);ModalDestinationTab.FlightNumber.val(-1);}
const ModalFlightTab={FlightNumber:$('#modalFlightNumber'),DateDeparture:$('#modalFlightDateDepart')}
const GetModalFlightTabValues=()=>{return{DateDeparture:ModalFlightTab.DateDeparture.find($('option:selected')).text(),FlightNumber:ModalFlightTab.FlightNumber.find($('option:selected')).text()}}
const ResetModalFlightTabValues=()=>{ModalFlightTab.DateDeparture.val(-1);ModalFlightTab.FlightNumber.val(-1);}
const SetModalInitialData=(data)=>{ModalDestinationTab.DateDeparture.val(data.flightDate);ModalDestinationTab.From.val(data.flightFrom);ModalDestinationTab.To.val(data.flightTo);ModalDestinationTab.FlightNumber.val(data.flightNumber);ModalFlightTab.DateDeparture.val(data.flightDate);ModalFlightTab.FlightNumber.val(data.flightNumber);FilterModalDestinationOptions();FilterModalFlightOptions();}
const RemoveAllErrorMessages=()=>{$('.validation-destination-error').text("")
$('.validation-flightNumber-error').text("")}
const ApplyOnClick=()=>{const CloseModalWithoutData=()=>{$('#onYourFlightModal').modal('hide');Filters.flightDate.val("-1");Filters.flightNumber.val("-1");Filters.flightFrom.val("-1");Filters.flightTo.val("-1");}
const ShowErrorMessage=()=>{if(activeTab.id=='destination-tab'){$('.validation-destination-error').text("Please select all options or leave all blank")}else{$('.validation-flightNumber-error').text("Please select all options or leave all blank")}}
const RemoveErrorMessage=()=>{if(activeTab.id=='destination-tab'){$('.validation-destination-error').text("")}else{$('.validation-flightNumber-error').text("")}}
let activeTab=$("#onYourFlightModal-tabs").find($('.active'))[0];let values;if(activeTab.id=='destination-tab'){values=GetModalDestinationTabValues();if(values.DateDeparture==""||values.FlightNumber==""||values.From==""||values.To==""){if(values.DateDeparture!=""||values.FlightNumber!=""||values.From!=""||values.To!=""){ShowErrorMessage();}else{RemoveErrorMessage();CloseModalWithoutData();}
return;}
RemoveErrorMessage();Filters.flightDate.val(values.DateDeparture);Filters.flightNumber.val(values.FlightNumber);Filters.flightFrom.val(values.From);Filters.flightTo.val(values.To);ResetModalFlightTabValues();}else{values=GetModalFlightTabValues();if(values.DateDeparture==""||values.FlightNumber==""){if(values.DateDeparture!=""||values.FlightNumber!=""){ShowErrorMessage();}else{RemoveErrorMessage();CloseModalWithoutData();}
return;}
let active=jsonFlights.f.filter(item=>{if(item.dt==values.DateDeparture&&item.n==values.FlightNumber)
return true;return false;})
values.From=active[0].d;values.To=active[0].a;ResetModalDestinationTabValues();}RemoveAllErrorMessages();$("#contentFilters").collapse('show');Filters.flightDate.val(values.DateDeparture);Filters.flightNumber.val(values.FlightNumber);Filters.flightFrom.val(values.From);Filters.flightTo.val(values.To);TriggerSearch();$('#onYourFlightModal').modal('hide');}
const ClearAllOnClick=()=>{ResetModalDestinationTabValues();ResetModalFlightTabValues();FilterModalDestinationOptions();FilterModalFlightOptions();RemoveAllErrorMessages();}
const FilterModalDestinationOptions=(e)=>{let modalDestinationTabValues=GetModalDestinationTabValues();let dataDates=jsonFlights.f.filter((item)=>{if(modalDestinationTabValues.From!=""&&item.d!=modalDestinationTabValues.From){return false;}
if(modalDestinationTabValues.To!=""&&item.a!=modalDestinationTabValues.To){return false;}
if(modalDestinationTabValues.FlightNumber!=""&&item.n!=modalDestinationTabValues.FlightNumber){return false;}
return true;});let dataFroms=jsonFlights.f.filter((item)=>{if(modalDestinationTabValues.DateDeparture!=""&&item.dt!=modalDestinationTabValues.DateDeparture){return false;}
if(modalDestinationTabValues.To!=""&&item.a!=modalDestinationTabValues.To){return false;}
if(modalDestinationTabValues.FlightNumber!=""&&item.n!=modalDestinationTabValues.FlightNumber){return false;}
return true;});let dataTos=jsonFlights.f.filter((item)=>{if(modalDestinationTabValues.DateDeparture!=""&&item.dt!=modalDestinationTabValues.DateDeparture){return false;}
if(modalDestinationTabValues.From!=""&&item.d!=modalDestinationTabValues.From){return false;}
if(modalDestinationTabValues.FlightNumber!=""&&item.n!=modalDestinationTabValues.FlightNumber){return false;}
return true;});let dataFlightNums=jsonFlights.f.filter((item)=>{if(modalDestinationTabValues.DateDeparture!=""&&item.dt!=modalDestinationTabValues.DateDeparture){return false;}
if(modalDestinationTabValues.From!=""&&item.d!=modalDestinationTabValues.From){return false;}
if(modalDestinationTabValues.To!=""&&item.a!=modalDestinationTabValues.To){return false;}
return true;});let dates=[...new Set(dataDates.map(x=>x.dt))];let froms=[...new Set(dataFroms.map(x=>x.d))];let tos=[...new Set(dataTos.map(x=>x.a))];let flightNums=[...new Set(dataFlightNums.map(x=>x.n))];ModalDestinationReloadOptions(dates,froms,tos,flightNums);ModalDestinationRestoreValues(modalDestinationTabValues)}
const ModalDestinationReloadOptions=(dates,froms,tos,flightNums)=>{ModalDestinationTab.DateDeparture.empty();ModalDestinationTab.DateDeparture.append(RenderSelectOptions(dates))
ModalDestinationTab.From.empty();ModalDestinationTab.From.append(RenderSelectOptions(froms.sort((a,b)=>a.localeCompare(b))))
ModalDestinationTab.To.empty();ModalDestinationTab.To.append(RenderSelectOptions(tos.sort((a,b)=>a.localeCompare(b))))
ModalDestinationTab.FlightNumber.empty();ModalDestinationTab.FlightNumber.append(RenderSelectOptions(flightNums.sort((a,b)=>a.length-b.length||a.localeCompare(b))))}
const ModalDestinationRestoreValues=(values)=>{if(values.DateDeparture!=""){ModalDestinationTab.DateDeparture.val(values.DateDeparture)}
if(values.From!=""){ModalDestinationTab.From.val(values.From)}
if(values.To!=""){ModalDestinationTab.To.val(values.To)}
if(values.FlightNumber!=""){ModalDestinationTab.FlightNumber.val(values.FlightNumber)}}
const FilterModalFlightOptions=()=>{let modalFlightTabValues=GetModalFlightTabValues();let dataDates=jsonFlights.f.filter((item)=>{if(modalFlightTabValues.FlightNumber!=""&&item.n!=modalFlightTabValues.FlightNumber){return false;}
return true;});let dataFlightNums=jsonFlights.f.filter((item)=>{if(modalFlightTabValues.DateDeparture!=""&&item.dt!=modalFlightTabValues.DateDeparture){return false;}
return true;});let dates=[...new Set(dataDates.map(x=>x.dt))];let flightNums=[...new Set(dataFlightNums.map(x=>x.n))];ModalFlightTab.DateDeparture.empty();ModalFlightTab.DateDeparture.append(RenderSelectOptions(dates))
ModalFlightTab.FlightNumber.empty();ModalFlightTab.FlightNumber.append(RenderSelectOptions(flightNums.sort((a,b)=>a.length-b.length||a.localeCompare(b))))
if(modalFlightTabValues.DateDeparture!=""){ModalFlightTab.DateDeparture.val(modalFlightTabValues.DateDeparture)}
if(modalFlightTabValues.FlightNumber!=""){ModalFlightTab.FlightNumber.val(modalFlightTabValues.FlightNumber)}}
const GetIfeSystem=()=>{let values=GetFilterValues();if(values.flightDate==''||values.flightFrom==''||values.flightNumber==''||values.flightTo=='')
return null;let activeFlights=jsonFlights.f.filter((item)=>{if(item.dt!=values.flightDate||item.d!=values.flightFrom||item.a!=values.flightTo||item.n!=values.flightNumber){return false;}
return true;});return activeFlights[0].f;}
const StoreFlightOnSession=(data)=>{window.sessionStorage.setItem("lastFlight",JSON.stringify(data))}
const GetFlightFromSession=(key)=>{var item=window.sessionStorage.getItem("lastFlight");if(item)
return JSON.parse(item);return null;}