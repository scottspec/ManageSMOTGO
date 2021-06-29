<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SelectedGridRefresh.ascx.vb" Inherits="Controls_SelectedGridRefresh" %>
<script type="text/javascript">
    Sys.Application.add_load(function () {
        $('div.TabBar a').click(function () {
            var linkText = $(this).text();
            var tag = linkText;
            //  alert(tag);
            var dataView = Web.DataView.find(tag, 'Tag');
            if (dataView) {
                if (dataView._isBusy == false && dataView.get_isDisplayed())
                    dataView.refresh(false);
            }
        });
    })

</script>

