/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */
namespace NPOI.XWPF.Model
{
    using System;
    using NPOI.OpenXmlFormats.Wordprocessing;

    /**
     * Base class for XWPF paragraphs
     * 
     * This class isn't used ...
     */
    [Obsolete("deprecated 3.16 beta1, scheduled for removal in 3.18")]
    public class XMLParagraph
    {
        protected CT_P paragraph;

        public XMLParagraph(CT_P paragraph)
        {
            this.paragraph = paragraph;
        }

        public CT_P GetCTP()
        {
            return paragraph;
        }
    }
}
