using Microsoft.ML.OnnxRuntime.Tensors;
using System.Text.Json.Serialization;

namespace Intex_group1_8.Models.ModelApi
{
    public class MummyData
    {
        [JsonPropertyName("square_north_south")]
        public float squarenorthsouth { get; set; }

        [JsonPropertyName("depth")]
        public float depth { get; set; }

        [JsonPropertyName("south_to_head")]
        public float southtohead { get; set; }

        [JsonPropertyName("square_east_west")]
        public float squareeastwest { get; set; }

        [JsonPropertyName("west_to_head")]
        public float westtohead { get; set; }

        [JsonPropertyName("length")]
        public float length { get; set; }

        [JsonPropertyName("burial_number")]
        public float burialnumber { get; set; }

        [JsonPropertyName("west_to_feet")]
        public float westtofeet { get; set; }

        [JsonPropertyName("south_to_feet")]
        public float southtofeet { get; set; }

        [JsonPropertyName("field_book_excavation_year")]
        public float fieldbookexcavationyear { get; set; }

        [JsonPropertyName("count")]
        public float count { get; set; }

        [JsonPropertyName("head_direction_E")]
        public float headdirection_E { get; set; }

        [JsonPropertyName("head_direction_W")]
        public float headdirection_W { get; set; }

        [JsonPropertyName("north_south_N")]
        public float northsouth_N { get; set; }

        [JsonPropertyName("east_west_E")]
        public float eastwest_E { get; set; }

        [JsonPropertyName("east_west_W")]
        public float eastwest_W { get; set; }

        [JsonPropertyName("adult_subadult_Adult")]
        public float adultsubadult_Adult { get; set; }

        [JsonPropertyName("adult_subadult_Non_Adult")]
        public float adultsubadult_Non_Adult { get; set; }

        [JsonPropertyName("preservation_Badly_deteriorated")]
        public float preservation_Badly_deteriorated { get; set; }

        //       [JsonPropertyName("preservation_Badly_disturbed")]
        //       public float preservation_Badly_disturbed { get; set; }

        //       [JsonPropertyName("preservation_Badly_preserved")]
        //        public float preservation_Badly_preserved { get; set; }

        [JsonPropertyName("preservation_Body_only")]
        public float preservation_Body_only { get; set; }

        //       [JsonPropertyName("preservation_Fair")]
        //       public float preservation_Fair { get; set; }

        //       [JsonPropertyName("preservation_Good")]
        //       public float preservation_Good { get; set; }

        //        [JsonPropertyName("preservation_Poor")]
        //       public float preservation_Poor { get; set; }

        [JsonPropertyName("preservation_SKELETON")]
        public float preservation_SKELETON { get; set; }

        [JsonPropertyName("preservation_Skull_only")]
        public float preservation_Skull_only { get; set; }

        [JsonPropertyName("preservation_badly_disturbed")]
        public float preservation_badly_disturbed { get; set; }

        [JsonPropertyName("preservation_badly_preserved")]
        public float preservation_badly_preserved { get; set; }
        [JsonPropertyName("preservation_bones")]
        public float preservation_bones { get; set; }

        [JsonPropertyName("preservation_bones_and_skull")]
        public float preservation_bones_and_skull { get; set; }

        [JsonPropertyName("preservation_disarticulated")]
        public float preservation_disarticulated { get; set; }

        [JsonPropertyName("preservation_fair")]
        public float preservation_fair { get; set; }

        [JsonPropertyName("preservation_good")]
        public float preservation_good { get; set; }

        [JsonPropertyName("preservation_headless_skeleton")]
        public float preservation_headless_skeleton { get; set; }

        [JsonPropertyName("preservation_infested_with_bugs")]
        public float preservation_infested_with_bugs { get; set; }

        [JsonPropertyName("preservation_poor")]
        public float preservation_poor { get; set; }

        [JsonPropertyName("preservation_poorly_preserved")]
        public float preservation_poorly_preserved { get; set; }

        [JsonPropertyName("preservation_scattered_bones")]
        public float preservation_scattered_bones { get; set; }

        [JsonPropertyName("preservation_scattered_bones_with_skull")]
        public float preservation_scattered_bones_with_skull { get; set; }

        [JsonPropertyName("preservation_skeletalized")]
        public float preservation_skeletalized { get; set; }

        [JsonPropertyName("preservation_very_disturbed")]
        public float preservation_very_disturbed { get; set; }

        [JsonPropertyName("preservation_well_wrapped")]
        public float preservation_well_wrapped { get; set; }

        [JsonPropertyName("preservation_wrapped")]
        public float preservation_wrapped { get; set; }

        [JsonPropertyName("preservation_wrapped_bones_showing")]
        public float preservation_wrapped_bones_showing { get; set; }

        [JsonPropertyName("preservation_wrapped_head_showing")]
        public float preservation_wrapped_head_showing { get; set; }

        [JsonPropertyName("goods_N")]
        public float goods_N { get; set; }

        [JsonPropertyName("goods_Y")]
        public float goods_Y { get; set; }

        [JsonPropertyName("haircolor_Black")]
        public float haircolor_Black { get; set; }

        [JsonPropertyName("haircolor_Blond")]
        public float haircolor_Blond { get; set; }

        [JsonPropertyName("haircolor_Brown")]
        public float haircolor_Brown { get; set; }

        [JsonPropertyName("haircolor_Brown_Read")]
        public float haircolor_Brown_Read { get; set; }

        [JsonPropertyName("haircolor_Brown_Red")]
        public float haircolor_Brown_Red { get; set; }

        [JsonPropertyName("haircolor_Red_Red_BI")]
        public float haircolor_Red_Red_BI { get; set; }

        [JsonPropertyName("haircolor_Y")]
        public float haircolor_Y { get; set; }

        [JsonPropertyName("samplescollected_False")]
        public float samplescollected_False { get; set; }

        [JsonPropertyName("samplescollected_True")]
        public float samplescollected_True { get; set; }
        [JsonPropertyName("area_NE")]
        public float area_NE { get; set; }

        [JsonPropertyName("area_NNW")]
        public float area_NNW { get; set; }

        [JsonPropertyName("area_NW")]
        public float area_NW { get; set; }

        [JsonPropertyName("area_SE")]
        public float area_SE { get; set; }

        [JsonPropertyName("area_SW")]
        public float area_SW { get; set; }

        [JsonPropertyName("ageatdeath_Adult")]
        public float ageatdeath_Adult { get; set; }

        [JsonPropertyName("ageatdeath_Child")]
        public float ageatdeath_Child { get; set; }

        [JsonPropertyName("ageatdeath_Infant")]
        public float ageatdeath_Infant { get; set; }

        [JsonPropertyName("ageatdeath_Newborn")]
        public float ageatdeath_Newborn { get; set; }

        [JsonPropertyName("Textile_value_Belt_probable_")]
        public float Textile_value_Belt_probable_ { get; set; }

        [JsonPropertyName("Textile_value_Blanket_shroud")]
        public float Textile_value_Blanket_shroud { get; set; }

        [JsonPropertyName("Textile_value_Blanket_shroud_probable")]
        public float Textile_value_Blanket_shroud_probable { get; set; }

        [JsonPropertyName("Textile_value_Cordage")]
        public float Textile_value_Cordage { get; set; }

        [JsonPropertyName("Textile_value_Face_bundle")]
        public float Textile_value_Face_bundle { get; set; }

        [JsonPropertyName("Textile_value_Fragmentary")]
        public float Textile_value_Fragmentary { get; set; }

        [JsonPropertyName("Textile_value_Fragmentary_Unknown")]
        public float Textile_value_Fragmentary_Unknown { get; set; }

        [JsonPropertyName("Textile_value_Head_covering")]
        public float Textile_value_Head_covering { get; set; }

        [JsonPropertyName("Textile_value_Other_Torn_Strip_Binding")]
        public float Textile_value_Other_Torn_Strip_Binding { get; set; }

        [JsonPropertyName("Textile_value_Ribbon")]
        public float Textile_value_Ribbon { get; set; }

        [JsonPropertyName("Textile_value_Ribbon_fragment")]
        public float Textile_value_Ribbon_fragment { get; set; }

        [JsonPropertyName("Textile_value_Ribbon_Torn_Strip")]
        public float Textile_value_Ribbon_Torn_Strip { get; set; }

        [JsonPropertyName("Textile_value_Rope")]
        public float Textile_value_Rope { get; set; }

        [JsonPropertyName("Textile_value_Tunic")]
        public float Textile_value_Tunic { get; set; }

        [JsonPropertyName("Textile_value_Tunic_sewn_fragmentary")]
        public float Textile_value_Tunic_sewn_fragmentary { get; set; }

        [JsonPropertyName("Textile_value_Unknown_probably_blanket_shroud")]
        public float Textile_value_Unknown_probably_blanket_shroud { get; set; }

        [JsonPropertyName("Textile_value_small_fragment_of_plain_weave")]
        public float Textile_value_small_fragment_of_plain_weave { get; set; }

        [JsonPropertyName("thickness_Coarse")]
        public float thickness_Coarse { get; set; }

        [JsonPropertyName("thickness_Extra_fine")]
        public float thickness_Extra_fine { get; set; }

        [JsonPropertyName("thickness_Fine")]
        public float thickness_Fine { get; set; }

        [JsonPropertyName("thickness_Fine_medium")]
        public float thickness_Fine_medium { get; set; }

        [JsonPropertyName("thickness_Medium")]
        public float thickness_Medium { get; set; }

        [JsonPropertyName("thickness_Very_fine")]
        public float thickness_Very_fine { get; set; }

        [JsonPropertyName("thickness_wool")]
        public float thickness_wool { get; set; }

        [JsonPropertyName("manipulation_Edge")]
        public float manipulation_Edge { get; set; }

        [JsonPropertyName("manipulation_Green_yarns")]
        public float manipulation_Green_yarns { get; set; }

        [JsonPropertyName("manipulation_Thread_single_stitch")]
        public float manipulation_Thread_single_stitch { get; set; }

        [JsonPropertyName("manipulation_Warp")]
        public float manipulation_Warp { get; set; }

        [JsonPropertyName("manipulation_Weft")]
        public float manipulation_Weft { get; set; }

        [JsonPropertyName("manipulation_Weft_pile_band")]
        public float manipulation_Weft_pile_band { get; set; }

        [JsonPropertyName("manipulation_Weft_red")]
        public float manipulation_Weft_red { get; set; }

        [JsonPropertyName("manipulation_Weft_Ribs")]
        public float manipulation_Weft_Ribs { get; set; }

        [JsonPropertyName("manipulation_Weft_decoration")]
        public float manipulation_Weft_decoration { get; set; }

        [JsonPropertyName("material_Linen")]
        public float material_Linen { get; set; }

        [JsonPropertyName("material_Linen_background")]
        public float material_Linen_background { get; set; }

        [JsonPropertyName("material_Linen_red")]
        public float material_Linen_red { get; set; }

        [JsonPropertyName("material_Linen_very_loosely_spun")]
        public float material_Linen_very_loosely_spun { get; set; }

        [JsonPropertyName("material_Other")]
        public float material_Other { get; set; }

        [JsonPropertyName("material_Other_burlap")]
        public float material_Other_burlap { get; set; }

        [JsonPropertyName("material_Other_vegetable_fiber")]
        public float material_Other_vegetable_fiber { get; set; }

        [JsonPropertyName("material_Wool")]
        public float material_Wool { get; set; }

        [JsonPropertyName("material_Wool_tapestry")]
        public float material_Wool_tapestry { get; set; }

        [JsonPropertyName("material_Wool_thread")]
        public float material_Wool_thread { get; set; }

        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
        squarenorthsouth,
        depth,
        southtohead,
        squareeastwest,
        westtohead,
        length,
        burialnumber,
        westtofeet,
        southtofeet,
        fieldbookexcavationyear,
        count,
        headdirection_E,
        headdirection_W,
        northsouth_N,
        eastwest_E,
        eastwest_W,
        adultsubadult_Adult,
        adultsubadult_Non_Adult,
        preservation_Badly_deteriorated,
 //       preservation_Badly_disturbed,
 //       preservation_Badly_preserved,
        preservation_Body_only,
  //      preservation_Fair,
   //     preservation_Good,
 //       preservation_Poor,
        preservation_SKELETON,
        preservation_Skull_only,
        preservation_badly_disturbed,
        preservation_badly_preserved,
        preservation_bones,
        preservation_bones_and_skull,
        preservation_disarticulated,
        preservation_fair,
        preservation_good,
        preservation_headless_skeleton,
        preservation_infested_with_bugs,
        preservation_poor,
        preservation_poorly_preserved,
        preservation_scattered_bones,
        preservation_scattered_bones_with_skull,
        preservation_skeletalized,
        preservation_very_disturbed,
        preservation_well_wrapped,
        preservation_wrapped,
        preservation_wrapped_bones_showing,
        preservation_wrapped_head_showing,
        goods_N,
        goods_Y,
        haircolor_Black,
        haircolor_Blond,
        haircolor_Brown,
        haircolor_Brown_Read,
        haircolor_Brown_Red,
        haircolor_Red_Red_BI,
        haircolor_Y,
        samplescollected_False,
        samplescollected_True,
        area_NE,
        area_NNW,
        area_NW,
        area_SE,
        area_SW,
        ageatdeath_Adult,
        ageatdeath_Child,
        ageatdeath_Infant,
        ageatdeath_Newborn,
        Textile_value_Belt_probable_,
        Textile_value_Blanket_shroud,
        Textile_value_Blanket_shroud_probable,
        Textile_value_Cordage,
        Textile_value_Face_bundle,
        Textile_value_Fragmentary,
        Textile_value_Fragmentary_Unknown,
        Textile_value_Head_covering,
        Textile_value_Other_Torn_Strip_Binding,
        Textile_value_Ribbon,
        Textile_value_Ribbon_fragment,
        Textile_value_Ribbon_Torn_Strip,
        Textile_value_Rope,
        Textile_value_Tunic,
        Textile_value_Tunic_sewn_fragmentary,
        Textile_value_Unknown_probably_blanket_shroud,
        Textile_value_small_fragment_of_plain_weave,
        thickness_Coarse,
        thickness_Extra_fine,
        thickness_Fine,
        thickness_Fine_medium,
        thickness_Medium,
        thickness_Very_fine,
        thickness_wool,
        manipulation_Edge,
        manipulation_Green_yarns,
        manipulation_Thread_single_stitch,
        manipulation_Warp,
        manipulation_Weft,
        manipulation_Weft_pile_band,
        manipulation_Weft_red,
        manipulation_Weft_Ribs,
        manipulation_Weft_decoration,
        material_Linen,
        material_Linen_background,
        material_Linen_red,
        material_Linen_very_loosely_spun,
        material_Other,
        material_Other_burlap,
        material_Other_vegetable_fiber,
        material_Wool,
        material_Wool_tapestry,
        material_Wool_thread
            };
            int[] dimensions = new int[] { 1, 104 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
