/*
Copyright 2019 Gfi Informatique

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using UnityEngine;

public class KeepInBounds : MonoBehaviour
{
    public Bounds bounds;

    // Update is called once per frame
    void Update()
    {
        if (!bounds.Contains(this.transform.localPosition))
            this.transform.localPosition = bounds.ClosestPoint(this.transform.localPosition);
    }
}