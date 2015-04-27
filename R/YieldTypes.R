##Load the file into a datatable using fread
##http://www.inside-r.org/packages/cran/data.table/docs/fread
yieldtypes <- fread("http://www.rma.usda.gov/FTP/References/insurance_control_elements/PASS/2015/2015_D00042_IceYieldType_YTD.txt")

#Removed spaces from column names
names(yieldtypes) <- sub(" ",".",names(yieldtypes))
names(yieldtypes) <- sub(" ",".",names(yieldtypes))


##Filter down to the necessary items
##This checks of the Yield Type code is in the set of items listed
filteredyieldtypes <- yieldtypes[is.element(yieldtypes$Yield.Type.Code,c("GX","UG","VC","VX"))]

filteredyieldtypes

