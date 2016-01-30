$.fn.mutuallyExcludedCheckBoxes = function () {
    var $checkboxes = this; // refers to selected checkboxes

    $checkboxes.click(function () {
        var $this = $(this),
            isChecked = $this.prop("checked");

        $checkboxes.prop("checked", false);
        $this.prop("checked", isChecked);
    });
};

// more elegant, just invoke the plugin
$(".resident").mutuallyExcludedCheckBoxes();
$(".goverment").mutuallyExcludedCheckBoxes();
$(".income").mutuallyExcludedCheckBoxes();
$(".category").mutuallyExcludedCheckBoxes();
$(".purpose").mutuallyExcludedCheckBoxes();
$(".payment").mutuallyExcludedCheckBoxes();